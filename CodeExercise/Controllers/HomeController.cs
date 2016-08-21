using CodeExercise.Managers;
using CodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeExercise.Controllers
{
    public class HomeController : Controller
    {
        private ILogManager LogManager { get; set; }
        /************************************************** COMMENTARY ***************************************************************\
         * 
         * I'm sure you guys already know it is good development practice to loosely couple objects.
         * It increases testability of the code and allows for extensability.
         * You can't apply SOLID principles (https://en.wikipedia.org/wiki/SOLID_(object-oriented_design) 
         * w/o programming to interfaces.
         * 
         * I just put the property there to note that I would include the management of logging in another class, 
         * potentially in another library altogether. 
         * 
         * It is also good practice to separate the tiers. So, the views and controllers wouldn't directly access the database tier.
         * Often, the models in the data tier would be converted to ViewModels for the view. 
         * 
         * Back to the LogManager: If I had more time to build this out, I would probably use Castle Windsor 
         * for dependency injection. Granted, dependency injection also adds complexity and it's been a few months since I used
         * Castle Windsor. Of course there would also be a constructor that took the logManager
         * 
         * I have also used RhinoMocks for mocking objects for tests.
         * I probably should spread these notes throughout the code.... Thanks for reading.
         * 
         * 
        \*****************************************************************************************************************************/

        public HomeController()
            :this(null)
        {

        }

        public HomeController(ILogManager logManager)
        {
            if (logManager != null)
            {
                LogManager = logManager;
            }
            else
            {
                LogManager = new LogManager();
            }
            
        }

        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult SuccessfulAuthorization(LinkedinUser user)
        {
            //log user
            LogManager.LogAuthorization(user);
            /**/




            //prepare form

            //
            return PartialView("BuildTeamSurveryWithCTA", user);
        }

        [HttpPost]
        public ActionResult RequestConsultation(string firstName, string lastName, string emailAddress)
        {
            /*************************************************************************************************************\
             * If I had more time, really cool stuff would happen here. 
             * Or at least connecting to the data source, likely through Entity Framework. 
             * Then again, I don't know if that is 100% legit for Linkedin. I think this qualifies as lead generation,
             * which I believe they want you to be a partner (or at least work with a partner)
             * in order to utilize their API for lead generation.
            \************************************************************************************************************/
            //

            return PartialView("ThankYou");
        }
    }
}