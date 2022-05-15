using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Intsar_F_Project.Models
{
    public class _Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "لا يزيد عدد حروف الاسم عن 50 حرف")]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }
        [Required]
        public string DriveLink { get; set; }
    }
}
