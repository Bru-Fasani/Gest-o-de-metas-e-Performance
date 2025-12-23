using System.ComponentModel.DataAnnotations;
using Gestão_de_metas_e_Performance.Models;

namespace Gestão_de_metas_e_Performance.Models
{
    public class Meta
    {
        [Key]
        public int IdMeta { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Type { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public EnumStatus StatusMeta { get; set; }

        [Required]
        public DateTime InicialDate { get; set; }

        [Required]
        public DateTime FinalDate { get; set; }

    }
}
