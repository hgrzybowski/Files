
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace FileRepository.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Import(HttpPostedFileBase file)
        {
            if(file.ContentLength > 0)
            {
                var path = Path.Combine(Server.MapPath("~/App_Data/Repository")
                                        , file.FileName);
                file.SaveAs(path);
            }
                return View("Index");
        }


        //if (file.ContentLength > 0)
        //    {
        //        var fileName = Path.GetFileName(file.FileName);
        //var path = Path.Combine( fileName);
        //file.SaveAs(path);
        //    }

}
}