using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.Authentication
{
    public class ResetPasswordRequestModel
    {
        public string? NewPassword { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
