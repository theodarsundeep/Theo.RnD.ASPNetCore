using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using Theo.RnD.ASPNetCore.Auth.Models;

namespace Theo.RnD.ASPNetCore.Auth.Helpers
{
    public static class IdentityRolesExtensions
    {
        private static async Task CreateSiteRoles(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        public static async Task CreateSiteRoles(this IApplicationBuilder objApp)
        {
            var roleManager = objApp.ApplicationServices.GetService(typeof(RoleManager<IdentityRole>)) as RoleManager<IdentityRole>;

            foreach (var role in Roles.All)
            {
                await CreateSiteRoles(roleManager, role);
            }
        }
    }
}
