
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using FileRepository.Abstract;
using System.Web.Mvc;
using FileRepository.Helpers;

namespace FileRepository.Controllers
{
    public class FileController : Controller
    {
        IFileHelper zaimplementowany_interfejs = new FileHelper();

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

        public ActionResult Delete(string path)
        {

            //Debug.WriteLine(path);
            string moja_sciezka_do_tego_projektu = AppDomain.CurrentDomain.BaseDirectory;
            string pelna_sciezka_do_moich_plikow = moja_sciezka_do_tego_projektu + "App_Data/Upload/";
            string sciezka = pelna_sciezka_do_moich_plikow + path;
            //Debug.WriteLine(sciezka);
            zaimplementowany_interfejs.Delete(sciezka);

            return RedirectToAction("Index");
        }

        public ActionResult Download(string filename)
        {

            string moja_sciezka_do_tego_projektu = AppDomain.CurrentDomain.BaseDirectory;
            string pelna_sciezka_do_moich_plikow = moja_sciezka_do_tego_projektu + "App_Data/Upload/";
            string sciezka = pelna_sciezka_do_moich_plikow + filename;

            byte[] fileBytes = System.IO.File.ReadAllBytes(sciezka);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filename);

        }
    }
}