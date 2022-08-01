using System.Threading.Tasks;
using VineforceVikas.Configuration.Dto;

namespace VineforceVikas.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
