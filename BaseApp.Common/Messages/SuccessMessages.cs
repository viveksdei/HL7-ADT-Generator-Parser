using Newtonsoft.Json;
using System.Net;
using System.Runtime.Serialization;

namespace BaseApp.Common.Messages
{
    public static class SuccessMessages
    {
        public const string DocumentFileUpload = "File uploaded successfully.";
        public const string DocumentFileEdit = "File edited successfully.";
        public const string Success = "Success";
        public const string Error = "Error";
        public const string NoRecordsFound = "No records found.";
    }
}
