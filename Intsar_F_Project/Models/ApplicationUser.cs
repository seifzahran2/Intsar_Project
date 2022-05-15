using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Intsar_F_Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsProjSent { get; set; }
        public bool IsRegSent { get; set; }
        public string Specialization { get; set; }

        public byte[] ProfilePic { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال اسمك")]
        public string Name { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال عمرك")]
        public int age { get; set; }
        [MaxLength(11, ErrorMessage = "لا يزيد الرقم القومي عن 11 رقم")]
        [MinLength(11, ErrorMessage = "لا يقل الرقم القومي عن 11 رقم")]
        [Required(ErrorMessage = "تاكد من ادخال رقم الهاتف")]
        public string mobileNumber { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال الرقم القومي")]
        [MaxLength(14, ErrorMessage = "لا يزيد الرقم القومي عن 14 رقم")]
        [MinLength(14, ErrorMessage = "لا يقل الرقم القومي عن 14 رقم")]
        [Phone]
        public string NationalID { get; set; }
        [Required(ErrorMessage = "تاكد من اختيار النوع ")]
        public string gender { get; set; }
        public string Role { get; set; }

    }
}
