using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Theo.RnD.ASPNetCore.Auth.Helpers
{
    public static class InitRolesData
    {
        private static async Task EnsureRoleCreated(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        public static async Task EnsureRolesCreated(this RoleManager<IdentityRole> roleManager)
        {
            await EnsureRoleCreated(roleManager, "CPMAdmin");
            await EnsureRoleCreated(roleManager, "CPMUser");
            await EnsureRoleCreated(roleManager, "CPMSuperUser");
        }
    }
}
