using System.Threading.Tasks;
using Abp.Application.Services;
using VineforceVikas.Sessions.Dto;

namespace VineforceVikas.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
