namespace FluentChange.Integrations.Tink
{

    public static class Scopes
    {
        public static string PROVIDERS_READ = "providers:read";
        public static string CREDENTIALS_READ = "credentials:read";
    }

    public enum Markets
    {
        DE = 1,
        FR = 2,
        IT = 3,
        AT = 4,
        BE = 5,
        DK = 6,
        FI = 7,
        NL = 8,
        NO = 9,
        PT = 10,
        ES = 11,
        SE = 12,
        GB = 13


    }

    public enum Locales
    {
        de_DE,
        fr_FR,
        en_US,

    }
}
