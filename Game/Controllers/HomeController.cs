using Game.Models;
using Game.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Controllers
{
    public class HomeController : Controller
    {
        private IQuestionsService _service;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger, IQuestionsService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            ViewBag.Questions = _service.GetAllQuestions(15);
            ViewBag.ButtonVisibility = "hidden";
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
