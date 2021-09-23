using DependencyInjectionWebApp.Interfaces;
using DependencyInjectionWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ITransientNumber TransientNumber_;
        private IScopedNumber ScopedNumber_;
        private ISingletonNumber SingletonNumber_;
        private ISingletonInstanceNumber SingletonInstanceNumber_;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, ITransientNumber TN,IScopedNumber SC, ISingletonNumber SI,ISingletonInstanceNumber SIN)
        {
            TransientNumber_ = TN;
            ScopedNumber_ = SC;
            SingletonNumber_ = SI;
            SingletonInstanceNumber_ = SIN;
            _logger = logger;
        }

        public IActionResult Index()
        {
            @ViewBag.Transient = TransientNumber_.Number;
            @ViewBag.Scoped = ScopedNumber_.Number;
            @ViewBag.Singleton = SingletonNumber_.Number;
            @ViewBag.SingletonInstance = SingletonInstanceNumber_.Number;

            return View();
        }

        public IActionResult Privacy()
        { 

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
