namespace BaseApp.Common
{
    public class JwtSetting
    {
        public string? Key { get; set; }
        public string? Audience { get; set; }
        public string? Authority { get; set; }
        public int TokenValidityInMinutes { get; set; }
        public int RefreshTokenValidityInDays { get; set; }
        public int ExpireIn { get; set; }
        public string? Issuer { get; set; }
        public string? Secret { get; set; }
    }
}
