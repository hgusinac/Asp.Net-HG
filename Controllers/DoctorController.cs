using Asp.Net_HG.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_HG.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

       [HttpPost]
        public IActionResult FeverCheck(string temp)
        {
            if(string.IsNullOrWhiteSpace(temp))
            {
                ViewBag.Msg = "You need to fill in Body temp";
                return View();
            }
            else
            {
                ViewBag.Msg = Fever.FeverCheck(temp);
            return View();
            }
        }

    }
}
