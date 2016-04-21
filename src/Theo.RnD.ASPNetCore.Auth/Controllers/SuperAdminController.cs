using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Theo.RnD.ASPNetCore.Auth.Models;

namespace Theo.RnD.ASPNetCore.Auth.Controllers
{
    [Authorize(Roles = Roles.SUPERUSER)]
    public class SuperUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
