using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreekCalendars.Controllers
{
    public class RushController : Controller
    {

        // GET: Rush
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckSubmit(string submitButton)
        {
            switch (submitButton)
            {
                case "View":
                    // delegate sending to another controller action
                    return (ViewCalendar());
                case "Compare":
                    // call another action to perform the cancellation
                    return (CompareCalendar());
                default:
                    // If they've submitted the form without a submitButton, 
                    // just return the view again.
                    return (View());
            }
        }

        [HttpPost]
        public ActionResult ViewCalendar()
        {
            string sigmaAlphaEpsilon = this.Request.Form["sigmaAlphaEpsilon"];
            if(sigmaAlphaEpsilon == "on")
            {
                return View("SigmaAlphaEpsilonCalendar");
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult CompareCalendar()
        {
            string sigmaAlphaEpsilon = this.Request.Form["sigmaAlphaEpsilon"];
            if (sigmaAlphaEpsilon == "on")
            {
                return View("SigmaAlphaEpsilonCalendar");
            }

            return View();
        }
    }
}