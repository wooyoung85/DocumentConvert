using System.Collections.Generic;
using System.Web.Mvc;

namespace DocumentConvert.Utils
{
    public class DocumentUtils
    {
        public static List<SelectListItem> GetDocumentLanguageList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "국문", Value = "KO" });
            list.Add(new SelectListItem { Text = "영문", Value = "EN" });
            list.Add(new SelectListItem { Text = "중문", Value = "CH" });

            return list;
        }

        public static List<SelectListItem> GetDocumentTypeList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "문서타입1", Value = "doc_type1" });
            list.Add(new SelectListItem { Text = "문서타입2", Value = "doc_type2" });
            list.Add(new SelectListItem { Text = "문서타입3", Value = "doc_type3" });

            return list;
        }
    }
}