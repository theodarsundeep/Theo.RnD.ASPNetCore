using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Theo.RnD.ASPNetCore.Auth.Models
{
    public class Roles
    {
        private static readonly string[] siteRoles = { ADMIN, USER, SUPERUSER, READONLY };

        public const string ADMIN = "SiteAdmin";

        public const string USER = "SiteUser";

        public const string SUPERUSER = "SiteSuperUser";

        public const string READONLY = "ReadOnly";

        public static IEnumerable<string> All { get { return siteRoles; } }
    }
}
