using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intsar_F_Project.Models
{
    public class DegComp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string ProjectIdea { get; set; }
        [Required]
        public string ExecutionQuality { get; set; }
        [Required]
        public string Gui { get; set; }
        [Required]
        public string ContentQuality { get; set; }
        [Required]
        public string complexity { get; set; }
        [Required]
        public string ProjectBbenefit { get; set; }
        public string language_Tools { get; set; }
        [Required]
        public string MasteringTheTools { get; set; }
        [Required]
        public string InfrastructureUsed { get; set; }
        public string Notes { get; set; }
        [Required]
        public string OverallRating { get; set; }

        [Required]
        public string Email { get; set; }
        public int compRegId { get; set; }
        public CompReg compReg { get; set; }
    }
}
