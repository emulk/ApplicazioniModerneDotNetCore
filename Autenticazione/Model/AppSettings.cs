namespace RazorAuthentication.Model
{
    public class AppSettings
    {
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
        public string? Secret { get; set; }
    }
}
