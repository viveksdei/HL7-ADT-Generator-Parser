﻿using BaseApp.Common.Enum;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace BaseApp.Repository
{
    public class BaseRepository
    {
        protected readonly IConfiguration Configuration;

        public object Connection { get; private set; }
        public object Transaction { get; private set; }

        public BaseRepository(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IDbConnection GetConnection()
        {
            string connectionString = Configuration.GetConnectionString("Default");
            return new SqlConnection(connectionString);
        }

        public async Task<T> GetAsync<T>(string query, DynamicParameters parameters = null, CommandType? commandType = null)
        {
            T result = default(T);
            using (IDbConnection conn = GetConnection())
            {
                result = await conn.QueryFirstOrDefaultAsync<T>(query, parameters, null, null, commandType);
            }

            return result;
        }
        public async Task<T> GetFirstOrDefaultAsync<T>(string query, DynamicParameters? parameter = null, CommandType? commandType = null, DataBaseNameEnum? databaseID = null)
        {
            T result = default(T);
            using (IDbConnection conn = GetConnection())
            {
                result = await conn.QueryFirstOrDefaultAsync<T>(query, parameter, null, null, commandType);
            }

            return result;
        }
        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CommandType commandType = CommandType.Text)
        {
            if (transaction != null) return await transaction.Connection.QueryAsync<T>(sql, param, transaction, commandType: commandType);

            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                return await conn.QueryAsync<T>(sql, param, transaction, commandType: commandType)
                    .ConfigureAwait(false);
            }
        }

        protected async Task<int> ExecuteAsync(string sql, DynamicParameters? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType commandType = CommandType.Text)
        {
          if (transaction != null) return await transaction.Connection.ExecuteAsync(sql, param, transaction, commandTimeout, commandType);

            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                return await conn.ExecuteAsync(sql, param, transaction, commandTimeout, commandType)
                    .ConfigureAwait(false);
            }
        }
        public async Task<int> AddAsync(string sql, DynamicParameters parameters = null, CommandType? commandType = null)
        {
            int result = 0;

            using (IDbConnection conn = GetConnection())
            {
                result = await conn.ExecuteAsync(sql, parameters, null, null, commandType);
            }

            return result;
        }


    }
}
