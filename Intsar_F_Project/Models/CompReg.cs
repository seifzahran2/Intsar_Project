using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intsar_F_Project.Models
{
    public class CompReg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال اسمك")]
        [MaxLength(50, ErrorMessage = "لا يزيد عدد حروف الاسم عن 50 حرف")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "تأكد من ادخال بريدك الالكتروني")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "تأكد من ادخال البريد الكتروني بشكل صحيح")]
        public string Email { get; set; }
        [Required(ErrorMessage = "تأكد من ادخال عنوانك المنزلي")]
        [MaxLength(100, ErrorMessage = "لا يزيد عدد حروف العنوان عن 100 حرف")]
        public string Address { get; set; }
        [Required(ErrorMessage = "تأكد من ادخال رقم حسابك البنكي")]
        public string BankAccount { get; set; }
        [Required(ErrorMessage = "تأكد من ادخال رقمك القومي")]
        [MaxLength(14, ErrorMessage = "لا يزيد الرقم القومي عن 14 رقم")]
        [MinLength(14, ErrorMessage = "لا يقل الرقم القومي عن 14 رقم")]
        public string NationalId { get; set; }
        [Required(ErrorMessage = "تأكد من ادخال عمرك")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "تأكد من ادخال عدد المشاركين في المشروع")]
        public int CompNum { get; set; }
        [Required(ErrorMessage = "تأكد من اختيار النوع")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "تأكد من اختيار نوع المشروع")]
        public string project_type { get; set; }
        [Required(ErrorMessage = "تأكد من اختيار مرحلتك الدراسيه")]
        public string Educational_level { get; set; }
        [Required(ErrorMessage = "تأكد من اختيار الفئه العمريه")]
        public string AgeType { get; set; }
        [Required(ErrorMessage = "تأكد من اختيار النظام التعليمي ")]
        public string educational_system { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsprojecSent { get; set; }
        public DegComp degComp { get; set; }
    }
}
