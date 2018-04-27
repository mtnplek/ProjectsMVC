using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myMVC.Models;

namespace myMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }


        [HttpGet]
        public ActionResult FeverCheck()
        {
            Fever feve = new Fever();
            return View(feve);
        }
        [HttpPost]
        public ActionResult FeverCheck(float fever)
        {
            Fever feve = new Fever();

            feve.Temp = fever;

            Fever.FeverCheck(feve);
            
            return View(feve);
        }


        [HttpGet]
        public ActionResult GuessGame(Guess guess)
        {
            return View(guess);
        }
        [HttpPost]
        public ActionResult GuessGame(int Gueess, Guess guess)
        {
            if (Session["ranSess"] != null)
            {
                guess.randomList = (List<int>)Session["ranSess"];
            }

            Session["ranSess"] = guess.randomList;

            guess.Guessed = Gueess;

            Guess.Guessing(guess);

            List<int> guessList = new List<int>();

            if (Session["guessSess"] != null)
            {
                guessList = (List<int>)Session["guessSess"];
            }

            guessList.Add(guess.Guessed);

            Session["guessSess"] = guessList;

            return View(guess);
        }






    }
}