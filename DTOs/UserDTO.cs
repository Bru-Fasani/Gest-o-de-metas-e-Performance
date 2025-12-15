using System.ComponentModel.DataAnnotations;

namespace Gestão_de_metas_e_Performance.DTOs
{
    public class UserDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Position { get; set; }
        public string Departament { get; set; }
    }
}
