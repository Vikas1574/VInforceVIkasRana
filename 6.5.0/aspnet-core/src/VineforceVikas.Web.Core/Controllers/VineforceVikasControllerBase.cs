using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VineforceVikas.Controllers
{
    public abstract class VineforceVikasControllerBase: AbpController
    {
        protected VineforceVikasControllerBase()
        {
            LocalizationSourceName = VineforceVikasConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
