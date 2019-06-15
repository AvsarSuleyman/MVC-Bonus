using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicFileUpdate.Controllers
{
    public class HomeController : Controller
    {
       private string path;

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(HttpPostedFileBase[] files,int id)
        {
            for (int i = 0; i < files.Length; i++)
            {
                    var folder = Server.MapPath("~/upload");
                    var randomfilename = Path.GetRandomFileName();
                    var filename = Path.ChangeExtension(randomfilename, ".jpg");
                    var path = Path.Combine(folder, filename);

                    files[i].SaveAs(path);
            }   
            return Json("");
        }
    }
}