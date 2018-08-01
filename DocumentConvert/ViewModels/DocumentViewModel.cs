using System.ComponentModel.DataAnnotations;

namespace DocumentConvert.ViewModels
{
    public class DocumentViewModel
    {
        [Required]
        [Display(Name = "언어")]
        public string DocumentLanguage { get; set; }

        [Required]
        [Display(Name = "문서 유형")]
        public string DocumentType { get; set; }
    }
}