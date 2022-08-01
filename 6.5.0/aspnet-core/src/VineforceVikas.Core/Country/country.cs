using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineforceVikas.Country
{  

    public class country : Entity<int>
    {
        public string Name { get; set; }
        public string Capital { get; set; }

    }
}
