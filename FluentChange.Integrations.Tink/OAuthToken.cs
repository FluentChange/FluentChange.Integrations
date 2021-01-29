using System;

namespace FluentChange.Integrations.Tink
{
    public class OAuthTokenCodeRequest
    {
        public string code { get; set; }

        public string client_id { get; set; }

        public string client_secret { get; set; }

        public string grant_type { get; set; } = "authorization_code";
    }

    public class OAuthTokenRefreshRequest
    {
        public string refresh_token { get; set; }

        public string client_id { get; set; }

        public string client_secret { get; set; }

        public string grant_type { get; set; } = "refresh_token";
    }


    public class LastAccessToken
    {
        public AccessTokenResponse Response { get; set; }
        public DateTime ResponseDateUtc { get; set; }
        public DateTime ExpiresDateUtc { get; set; }
    }
    public class AccessTokenResponse
    {
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string scope { get; set; }
        public string id_hint { get; set; }
    }

}
