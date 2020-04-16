using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("submit")]    
        public IActionResult Submit(Survey survey)
        {
            Survey survey1 = new Survey()
            {
                Name = survey.Name,
                Location = survey.Location,
                Language = survey.Language,
                Comment = survey.Comment
            };
            return View("Result", survey1);
        }

        [HttpGet("result")]
        public IActionResult Result(Survey survey1)
        {
            return View("Result", survey1);
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
