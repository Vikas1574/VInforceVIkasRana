﻿using System.Threading.Tasks;
using Abp.Application.Services;
using VineforceVikas.Authorization.Accounts.Dto;

namespace VineforceVikas.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
