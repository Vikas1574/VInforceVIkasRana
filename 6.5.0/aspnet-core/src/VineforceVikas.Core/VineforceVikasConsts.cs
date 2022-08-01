using VineforceVikas.Debugging;

namespace VineforceVikas
{
    public class VineforceVikasConsts
    {
        public const string LocalizationSourceName = "VineforceVikas";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "403b78a1b63a4209b1b984fc8cbd71aa";
    }
}
