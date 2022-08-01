using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace VineforceVikas.Localization
{
    public static class VineforceVikasLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(VineforceVikasConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(VineforceVikasLocalizationConfigurer).GetAssembly(),
                        "VineforceVikas.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
