using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineforceVikas.Country.Dto
{
    [AutoMap(typeof(country))]
    public class countryDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Capital { get; set; }
    }
}
