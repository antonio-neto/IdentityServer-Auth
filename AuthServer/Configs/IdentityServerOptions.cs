namespace AuthServer.Configs
{
    public class IdentityServerOptions
    {
        public string RedirectUris { get; set; }

        public string PostLogoutRedirectUris { get; set; }
        
        public string AllowedCorsOrigins { get; set; }
    }
}
