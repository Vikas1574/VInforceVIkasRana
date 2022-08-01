using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VineforceVikas.Configuration.Dto;

namespace VineforceVikas.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VineforceVikasAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
