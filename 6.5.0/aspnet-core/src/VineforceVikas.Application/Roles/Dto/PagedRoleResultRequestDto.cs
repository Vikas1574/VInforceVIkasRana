using Abp.Application.Services.Dto;

namespace VineforceVikas.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

