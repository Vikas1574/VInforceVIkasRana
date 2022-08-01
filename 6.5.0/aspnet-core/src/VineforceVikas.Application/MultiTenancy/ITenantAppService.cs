using Abp.Application.Services;
using VineforceVikas.MultiTenancy.Dto;

namespace VineforceVikas.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

