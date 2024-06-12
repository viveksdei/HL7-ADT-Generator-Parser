using BaseApp.Common.Enum;


namespace BaseApp.Model.Log
{
    public class APIResponse
    {
        public APIResponse(StatusCodesEnum status, object? result, string? fileType = null!)
        {
            StatusCode = status;
            Result = result;
            FileType = fileType;
        }
        public object? Result { get; set; }
        public StatusCodesEnum StatusCode { get; set; }
        public string? FileType { get; set; }
    }

}
