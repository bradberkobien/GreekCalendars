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
                    // call another action 
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
            //fraternities
            string betaThetaPi = this.Request.Form["betaThetaPi"];
            string deltaChi = this.Request.Form["deltaChi"];
            string deltaTauDelta = this.Request.Form["deltaTauDelta"];
            string lambdaChiAlpha = this.Request.Form["lambdaChiAlpha"];
            string phiDeltaTheta = this.Request.Form["phiDeltaTheta"];
            string phiGammaDelta = this.Request.Form["phiGammaDelta"];
            string piKappaAlpha = this.Request.Form["piKappaAlpha"];
            string sigmaAlphaEpsilon = this.Request.Form["sigmaAlphaEpsilon"];
            string sigmaChi = this.Request.Form["sigmaChi"];
            string sigmaNu = this.Request.Form["sigmaNu"];
            string thetaXi = this.Request.Form["thetaXi"];

            //sororities
            string alphaPhi = this.Request.Form["alphaPhi"];
            string alphaSigmaAlpha = this.Request.Form["alphaSigmaAlpha"];

            if (sigmaAlphaEpsilon == "on")
            {
                return View("SigmaAlphaEpsilonCalendar");
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult CompareCalendar()
        {
            //fraternities
            string betaThetaPi = this.Request.Form["betaThetaPi"];
            string deltaChi = this.Request.Form["deltaChi"];
            string deltaTauDelta = this.Request.Form["deltaTauDelta"];
            string lambdaChiAlpha = this.Request.Form["lambdaChiAlpha"];
            string phiDeltaTheta = this.Request.Form["phiDeltaTheta"];
            string phiGammaDelta = this.Request.Form["phiGammaDelta"];
            string piKappaAlpha = this.Request.Form["piKappaAlpha"];
            string sigmaAlphaEpsilon = this.Request.Form["sigmaAlphaEpsilon"];
            string sigmaChi = this.Request.Form["sigmaChi"];
            string sigmaNu = this.Request.Form["sigmaNu"];
            string thetaXi = this.Request.Form["thetaXi"];

            //sororities
            string alphaPhi = this.Request.Form["alphaPhi"];
            string alphaSigmaAlpha = this.Request.Form["alphaSigmaAlpha"];

            if (sigmaAlphaEpsilon == "on")
            {
                return View("SigmaAlphaEpsilonCalendar");
            }

            return View();
        }
    }
}