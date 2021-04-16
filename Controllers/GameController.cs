using Asp.Net_HG.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_HG.Controllers
{
    public class GameController : Controller
    {
       

        [HttpGet]
        public IActionResult NumbersGame()
        {
            if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString("randomNumber")))
            {
                int randomNumber = Number.GetRandomNum();
                HttpContext.Session.SetInt32("randomNumber", randomNumber);
            }

            return View();
        }


        [HttpPost]
        public IActionResult NumbersGame(int Userinput)
        {
            if (!string.IsNullOrWhiteSpace(HttpContext.Session.GetString("randomNumber")))
            {
                int newrandom = (int)HttpContext.Session.GetInt32("randomNumber");
                string message = Number.Rightguess(Convert.ToInt32(Userinput), newrandom);
                ViewBag.msg = message;
            }
            else
            {
                ViewBag.msg = " You most enter a number";
            }
            return View();

        }
        [HttpGet]
        public IActionResult Restart()//Restart randomNumber game 
        {
            int randomNumber = Number.GetRandomNum();
            HttpContext.Session.SetInt32("randomNumber", randomNumber);
            ViewBag.New = randomNumber;
            return RedirectToAction(nameof(NumbersGame));
        }
        
    }
}




