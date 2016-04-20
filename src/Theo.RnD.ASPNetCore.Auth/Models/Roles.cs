using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Theo.RnD.ASPNetCore.Auth.Models
{
    public class Roles
    {
        private static readonly string[] siteRoles = { "SiteAdmin", "SiteUser", "SiteSuperUser" };

        public static string Admin { get; } = siteRoles[0];

        public static string User { get; } = siteRoles[1];

        public static string SuperUser { get; } = siteRoles[2];

        public static IEnumerable<string> All { get { return siteRoles; } }

    }
}
