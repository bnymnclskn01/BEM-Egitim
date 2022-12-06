using Fatih.Karsli.Models.DatabaseModelContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fatih.Karsli.Controllers
{
    public class AboutController : Controller
    {
        private FatihKarsliDatabaseContext context = new FatihKarsliDatabaseContext();
        public IActionResult Index()
        {
            var model = context.Abouts.ToList();
            return View(model);
        }
    }
}
