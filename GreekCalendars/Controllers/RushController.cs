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


            //fraternities
            if (betaThetaPi == "on")
            {
                return View("BetaThetaPiCalendar");
            }
            if (deltaChi == "on")
            {
                return View("DeltaChiCalendar");
            }
            if (deltaTauDelta == "on")
            {
                return View("DeltaTauDeltaCalendar");
            }
            if (lambdaChiAlpha == "on")
            {
                return View("LambdaChiAlphaCalendar");
            }
            if (phiDeltaTheta == "on")
            {
                return View("PhiDeltaThetaCalendar");
            }
            if (phiGammaDelta == "on")
            {
                return View("PhiGammaDeltaCalendar");
            }
            if (piKappaAlpha == "on")
            {
                return View("PiKappaAlphaCalendar");
            }
            if (sigmaAlphaEpsilon == "on")
            {
                return View("SigmaAlphaEpsilonCalendar");
            }
            if (sigmaChi == "on")
            {
                return View("SigmaChiCalendar");
            }
            if (sigmaNu == "on")
            {
                return View("SigmaNuCalendar");
            }
            if (thetaXi == "on")
            {
                return View("ThetaXiCalendar");
            }

            //sororities
            if (alphaPhi == "on")
            {
                return View("AlphaPhiCalendar");
            }
            if (alphaSigmaAlpha == "on")
            {
                return View("AlphaSigmaAlphaCalendar");
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

            //fraternities

            //beta theta pi
            if (betaThetaPi == "on" && deltaChi == "on")
            {
                return View("BetaThetaPiandDeltaChiCalendar");
            }
            if (betaThetaPi == "on" && deltaTauDelta == "on")
            {
                return View("BetaThetaPiandDeltaTauDeltaCalendar");
            }
            if (betaThetaPi == "on" && lambdaChiAlpha == "on")
            {
                return View("BetaThetaPiandLambdaChiAlphaCalendar");
            }
            if (betaThetaPi == "on" && phiDeltaTheta == "on")
            {
                return View("BetaThetaPiandPhiDeltaThetaCalendar");
            }
            if (betaThetaPi == "on" && phiGammaDelta == "on")
            {
                return View("BetaThetaPiandPhiGammaDeltaCalendar");
            }
            if (betaThetaPi == "on" && piKappaAlpha == "on")
            {
                return View("BetaThetaPiandPiKappaAlphaCalendar");
            }
            if (betaThetaPi == "on" && sigmaAlphaEpsilon == "on")
            {
                return View("BetaThetaPiandSigmaAlphaEpsilonCalendar");
            }
            if (betaThetaPi == "on" && sigmaChi == "on")
            {
                return View("BetaThetaPiandSigmaChiCalendar");
            }
            if (betaThetaPi == "on" && sigmaNu == "on")
            {
                return View("BetaThetaPiandSigmaNuCalendar");
            }
            if (betaThetaPi == "on" && thetaXi == "on")
            {
                return View("BetaThetaPiandThetaXiCalendar");
            }

            //delta chi
            if (deltaChi == "on" && lambdaChiAlpha == "on")
            {
                return View("DeltaChiandLambdaChiAlphaCalendar");
            }
            if (deltaChi == "on" && phiDeltaTheta == "on")
            {
                return View("DeltaChiandPhiDeltaThetaCalendar");
            }
            if (deltaChi == "on" && phiGammaDelta == "on")
            {
                return View("DeltaChiandPhiGammaDeltaCalendar");
            }
            if (deltaChi == "on" && piKappaAlpha == "on")
            {
                return View("DeltaChiandPiKappaAlphaCalendar");
            }
            if (deltaChi == "on" && sigmaAlphaEpsilon == "on")
            {
                return View("DeltaChiandSigmaAlphaEpsilonCalendar");
            }
            if (deltaChi == "on" && sigmaChi == "on")
            {
                return View("DeltaChiandSigmaChiCalendar");
            }
            if (deltaChi == "on" && sigmaNu == "on")
            {
                return View("DeltaChiandSigmaNuCalendar");
            }
            if (deltaChi == "on" && thetaXi == "on")
            {
                return View("DeltaChiandThetaXiCalendar");
            }

            //delta tau delta
            if (deltaTauDelta == "on" && lambdaChiAlpha == "on")
            {
                return View("DeltaTauDeltaandLambdaChiAlphaCalendar");
            }
            if (deltaTauDelta == "on" && phiDeltaTheta == "on")
            {
                return View("DeltaTauDeltaandPhiDeltaThetaCalendar");
            }
            if (deltaTauDelta == "on" && phiGammaDelta == "on")
            {
                return View("DeltaTauDeltaandPhiGammaDeltaCalendar");
            }
            if (deltaTauDelta == "on" && piKappaAlpha == "on")
            {
                return View("DeltaTauDeltaandPiKappaAlphaCalendar");
            }
            if (deltaTauDelta == "on" && sigmaAlphaEpsilon == "on")
            {
                return View("DeltaTauDeltaandSigmaAlphaEpsilonCalendar");
            }
            if (deltaTauDelta == "on" && sigmaChi == "on")
            {
                return View("DeltaTauDeltaandSigmaChiCalendar");
            }
            if (deltaTauDelta == "on" && sigmaNu == "on")
            {
                return View("DeltaTauDeltaandSigmaNuCalendar");
            }
            if (deltaTauDelta == "on" && thetaXi == "on")
            {
                return View("DeltaTauDeltaandThetaXiCalendar");
            }

            //lambda chi alpha
            if (lambdaChiAlpha == "on" && phiDeltaTheta == "on")
            {
                return View("LambdaChiAlphaandPhiDeltaThetaCalendar");
            }
            if (lambdaChiAlpha == "on" && phiGammaDelta == "on")
            {
                return View("LambdaChiAlphaandPhiGammaDeltaCalendar");
            }
            if (lambdaChiAlpha == "on" && piKappaAlpha == "on")
            {
                return View("LambdaChiAlphaandPiKappaAlphaCalendar");
            }
            if (lambdaChiAlpha == "on" && sigmaAlphaEpsilon == "on")
            {
                return View("LambdaChiAlphaandSigmaAlphaEpsilonCalendar");
            }
            if (lambdaChiAlpha == "on" && sigmaChi == "on")
            {
                return View("LambdaChiAlphaandSigmaChiCalendar");
            }
            if (lambdaChiAlpha == "on" && sigmaNu == "on")
            {
                return View("LambdaChiAlphaandSigmaNuCalendar");
            }
            if (lambdaChiAlpha == "on" && thetaXi == "on")
            {
                return View("LambdaChiAlphaandThetaXiCalendar");
            }

            //phi delta theta
            if (phiDeltaTheta == "on" && phiGammaDelta == "on")
            {
                return View("PhiDeltaThetaandPhiGammaDeltaCalendar");
            }
            if (phiDeltaTheta == "on" && piKappaAlpha == "on")
            {
                return View("PhiDeltaThetaandPiKappaAlphaCalendar");
            }
            if (phiDeltaTheta == "on" && sigmaAlphaEpsilon == "on")
            {
                return View("PhiDeltaThetaandSigmaAlphaEpsilonCalendar");
            }
            if (phiDeltaTheta == "on" && sigmaChi == "on")
            {
                return View("PhiDeltaThetaandSigmaChiCalendar");
            }
            if (phiDeltaTheta == "on" && sigmaNu == "on")
            {
                return View("PhiDeltaThetaandSigmaNuCalendar");
            }
            if (phiDeltaTheta == "on" && thetaXi == "on")
            {
                return View("PhiDeltaThetaandThetaXiCalendar");
            }

            //phi gamma delta
            if (phiGammaDelta == "on" && piKappaAlpha == "on")
            {
                return View("PhiGammaDeltaandPiKappaAlphaCalendar");
            }
            if (phiGammaDelta == "on" && sigmaAlphaEpsilon == "on")
            {
                return View("PhiGammaDeltaandSigmaAlphaEpsilonCalendar");
            }
            if (phiGammaDelta == "on" && sigmaChi == "on")
            {
                return View("PhiGammaDeltaandSigmaChiCalendar");
            }
            if (phiGammaDelta == "on" && sigmaNu == "on")
            {
                return View("PhiGammaDeltaandSigmaNuCalendar");
            }
            if (phiGammaDelta == "on" && thetaXi == "on")
            {
                return View("PhiGammaDeltaandThetaXiCalendar");
            }

            //pi kappa alpha
            if (piKappaAlpha == "on" && sigmaAlphaEpsilon == "on")
            {
                return View("PiKappaAlphaandSigmaAlphaEpsilonCalendar");
            }
            if (piKappaAlpha == "on" && sigmaChi == "on")
            {
                return View("PiKappaAlphaandSigmaChiCalendar");
            }
            if (piKappaAlpha == "on" && sigmaNu == "on")
            {
                return View("PiKappaAlphaandSigmaNuCalendar");
            }
            if (piKappaAlpha == "on" && thetaXi == "on")
            {
                return View("PiKappaAlphaandThetaXiCalendar");
            }

            //sigma alpha epsilon
            if (sigmaAlphaEpsilon == "on" && sigmaChi == "on")
            {
                return View("SigmaAlphaEpsilonandSigmaChiCalendar");
            }
            if (sigmaAlphaEpsilon == "on" && sigmaNu == "on")
            {
                return View("SigmaAlphaEpsilonandSigmaNuCalendar");
            }
            if (sigmaAlphaEpsilon == "on" && thetaXi == "on")
            {
                return View("SigmaAlphaEpsilonandThetaXiCalendar");
            }

            //sigma chi
            if (sigmaChi == "on" && sigmaNu == "on")
            {
                return View("SigmaChiandSigmaNuCalendar");
            }
            if (sigmaChi == "on" && thetaXi == "on")
            {
                return View("SigmaChiandThetaXiCalendar");
            }

            //sigma nu
            if (sigmaNu == "on" && thetaXi == "on")
            {
                return View("SigmaNuandThetaXiCalendar");
            }

            //sororities
            if (alphaPhi == "on" && alphaSigmaAlpha == "on")
            {
                return View("AlphaPhiandAlphaSigmaAlphaCalendar");
            }


            return View();
        }
    }
}