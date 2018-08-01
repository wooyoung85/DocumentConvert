using DocumentConvert.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace DocumentConvert.Controllers
{
    public class SchemaController : Controller
    {
        private string json_file_path = "/Content/document/definition/{0}_{1}.json";

        // GET: /Schema/
        public ActionResult Index()
        {
            ViewBag.DocumentLanguageList = DocumentUtils.GetDocumentLanguageList();
            ViewBag.DocumentTypeList = DocumentUtils.GetDocumentTypeList();
            return View();
        }

        [HttpPost]
        public JsonResult JsonLoad(string language, string type)
        {
            string path = Server.MapPath(string.Format(json_file_path, language, type));
            List<string> results = new List<string>();
            try
            {
                if (!System.IO.File.Exists(path))
                {
                    System.IO.File.WriteAllText(path, "[]");
                }
                results.Add(System.IO.File.ReadAllText(path));
            }
            catch (IOException e)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                results.Add(e.Message);
            }

            return Json(results);
        }

        [HttpPost]
        public JsonResult Update(string language, string type, string documents)
        {
            ViewBag.DocumentLanguageList = DocumentUtils.GetDocumentLanguageList();
            ViewBag.DocumentTypeList = DocumentUtils.GetDocumentTypeList();
            string json = JsonConvert.SerializeObject(documents);

            //write string to file
            string path = Server.MapPath(string.Format(json_file_path, language, type));

            System.IO.File.WriteAllText(path, string.Empty);
            System.IO.File.WriteAllText(path, documents);
            return Json(documents);
        }
    }
}