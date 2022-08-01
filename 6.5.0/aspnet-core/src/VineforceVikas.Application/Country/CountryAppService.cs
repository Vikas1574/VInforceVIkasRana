using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineforceVikas.Authorization;
using VineforceVikas.Country.Dto;

namespace VineforceVikas.Country
{
    [AbpAuthorize(PermissionNames.Pages_Country)]
    public class CountryAppService : CrudAppService<country, countryDto>
    {
        public CountryAppService(IRepository<country, int> repository) : base(repository)
        {

        }
    }
}
