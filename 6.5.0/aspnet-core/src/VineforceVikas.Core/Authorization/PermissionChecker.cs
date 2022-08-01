using Abp.Authorization;
using VineforceVikas.Authorization.Roles;
using VineforceVikas.Authorization.Users;

namespace VineforceVikas.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
