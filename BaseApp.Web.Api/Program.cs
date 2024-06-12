using BaseApp.Common;
using BaseApp.IRepository.Authentication;
using BaseApp.IRepository.Role;
using BaseApp.IRepository.Screen;
using BaseApp.IRepository.User;
using BaseApp.IService.Authentication;
using BaseApp.IService.HL7.ADT.AdmitVisit;
using BaseApp.IService.HL7.ADT.DischargeEndVisit;
using BaseApp.IService.HL7.ADT.TransferPatient;
using BaseApp.IService.Role;
using BaseApp.IService.Screen;
using BaseApp.IService.User;
using BaseApp.Repository.Authentication;
using BaseApp.Repository.Role;
using BaseApp.Repository.Screen;
using BaseApp.Repository.User;
using BaseApp.Service.Authentication;
using BaseApp.Service.HL7.ADT.AdmitVisit;
using BaseApp.Service.HL7.ADT.DischargeEndVisit;
using BaseApp.Service.HL7.ADT.TransferPatient;
using BaseApp.Service.Role;
using BaseApp.Service.Screen;
using BaseApp.Service.User;
using BaseApp.Web.Api;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.FullName);
    // Other Swagger configurations...
});
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins(config.GetSection("ApplicationUrl").ToString(), "http://localhost:4200")
    .SetPreflightMaxAge(TimeSpan.FromSeconds(86400))
    .AllowAnyOrigin()
    .AllowAnyMethod()
        .AllowAnyHeader();
}));

#region Connection String
string mySqlConnectionStr = (config["ConnectionStrings:Default"]);
#endregion

#region Dependency Injection
builder.Services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IScreenRepository, ScreenRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IScreenService, ScreenService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAdmitVisitService, AdmitVisitService>();
builder.Services.AddScoped<ITransferPatientService, TransferPatientService>();
builder.Services.AddScoped<IDischargeEndVisitService, DischargeEndVisitService>();
#endregion

#region JWT Token

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };

});

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});


#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("corsapp");
}

app.UseAuthentication();
app.UseHttpsRedirection();

app.UseHttpsRedirection();
app.UseAuthentication();

app.MapControllers();

//app.MapControllers();

app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();


