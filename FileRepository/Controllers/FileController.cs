
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileRepository.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            ViewBag.Message = "Lista plików";
            string moja_sciezka_do_tego_projektu = AppDomain.CurrentDomain.BaseDirectory;
            string pelna_sciezka_do_moich_plikow = moja_sciezka_do_tego_projektu + "/App_Data/Upload/";
            DirectoryInfo dirInfo = new DirectoryInfo(pelna_sciezka_do_moich_plikow);
            List<FileInfo> files = dirInfo.GetFiles().ToList();
            return View(files);
        }

        [HttpPost]
        public ActionResult Import(HttpPostedFileBase file)
        {
            if (file != null)
            {
                var InputFileName = Path.GetFileName(file.FileName);
                var ServerSavePath = Path.Combine(Server.MapPath("~/App_Data/Upload/") + InputFileName);
                file.SaveAs(ServerSavePath);

            }
            return RedirectToAction("Index");
        }


    }
}