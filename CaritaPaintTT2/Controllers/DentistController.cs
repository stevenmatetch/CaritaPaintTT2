using CaritaPaintTT2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaritaPaintTT2.Controllers
{
    public class DentistController : Controller
    {
        // GET: Dentist
        public ActionResult Paint()
        {
            return View();
        }
        
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Picture(DentistAddAttachementModel model, string imageData)
        //{
        //    if (TempData["iOrdSNr"] != null)
        //    {
        //        model.OrdSNr = Convert.ToInt32(TempData["iOrdSNr"]);

        //        if (!string.IsNullOrEmpty(model.cTxtP) && !string.IsNullOrEmpty(model.Name))
        //        {
        //            if (model.Name.Length >= 5)
        //            {
        //                string last = model.Name.Substring(model.Name.Length - 4).ToLower();
        //                if (last == ".png" || last == ".jpg")
        //                {
        //                    string result = model.Name.Remove(model.Name.Length - 4);
        //                    result += last;
        //                    model.Name = result;
        //                }
        //            }
        //            else
        //            {
        //                model.Name += ".png";
        //            }


        //            string fileNameWitPath = Path.Combine(Server.MapPath("~/SavePicture"), model.Name);

        //            using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
        //            {
        //                using (BinaryWriter bw = new BinaryWriter(fs))
        //                {
        //                    byte[] array = Convert.FromBase64String(imageData);
        //                    bw.Write(array);
        //                    bw.Close();
        //                    string cResultP = "";
        //                    int? iDntPNrWSP = Session["iDntPNrWSP"] as int?;
        //                    string cSessionStrP = Session["cSessionStrP"] as string;
        //                    int? iDtlPNrWSP = Convert.ToInt32(Session["UserStyle"] ?? 0);
        //                    int? iFileNrP = 0;
        //                    // string cNameFileP = ;
        //                    StrongTypesNS.OrdSDATtDataTable OrdSDATt = new StrongTypesNS.OrdSDATtDataTable();
        //                    OrdSDATt.AddOrdSDATtRow(model.OrdSNr, 1, 1, array);

        //                    CaritaProxy.Carita.wsDntOrdsdupload(out cResultP, iDntPNrWSP, cSessionStrP, iDtlPNrWSP, model.OrdSNr, model.cTxtP, model.Name, array.Length, DateTime.Now, OrdSDATt, out iFileNrP);

        //                    if (cResultP != "OK")
        //                    {
        //                        model.Order = DentistOrderHelper((int)TempData["iOrdSNr"]);
        //                        model.OrdSNr = Convert.ToInt32(TempData["iOrdSNr"]);
        //                        TempData["iOrdSNr"] = Convert.ToInt32(TempData["iOrdSNr"]);
        //                        TempData["AlertDanger"] = cResultP;
        //                    }
        //                    else
        //                    {
        //                        TempData["SuccessMessage"] = "filen har lagts till.";
        //                    }
        //                }

        //                fs.Close();
        //                return Redirect("ViewOrderDetails?iOrdSNrP=" + model.OrdSNr.ToString());
        //            }
        //        }
        //    }
        //    //model.Order = DentistOrderHelper((int)TempData["iOrdSNr"]);
        //    //model.OrdSNr = Convert.ToInt32(TempData["iOrdSNr"]);
        //    //TempData["iOrdSNr"] = Convert.ToInt32(TempData["iOrdSNr"]);
        //    return View(model);

        //}

        public ActionResult Whiteboard()
        {
            return View();
        }

    }
}