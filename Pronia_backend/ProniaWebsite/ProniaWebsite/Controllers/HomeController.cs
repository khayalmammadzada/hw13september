using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProniaWebsite.DAL;
using ProniaWebsite.Models;
using ProniaWebsite.ViewModels.Home;
//using ProniaWebsite.Models;

namespace ProniaWebsite.Controllers
{
    public class HomeController : Controller
    {
        ProniaContext _context;

       public HomeController(ProniaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.Sliders = _context.Sliders.OrderBy(x => x.Order);
            return View(vm);
        }

        
    }
}
