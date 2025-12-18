using Gestão_de_metas_e_Performance.Models;
using System.ComponentModel.DataAnnotations;

namespace Gestão_de_metas_e_Performance.DTOs
{
    public class MetaDTO 
    {
        [Key]
        public int Idmeta { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Type { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public EnumStatus StatusMeta { get; set; }

        [Required]
        public DateTime Inicial { get; set; }

        [Required]
        public DateTime Final { get; set; }
    }
}
