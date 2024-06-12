using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.Authentication
{
    public class PasswordHistoryModel
    {
        public string? Password { get; set; }
        public string? Passwordsalt { get; set; }
    }
}
