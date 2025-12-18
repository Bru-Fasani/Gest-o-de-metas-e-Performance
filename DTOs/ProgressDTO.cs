using Gestão_de_metas_e_Performance.Models;

namespace Gestão_de_metas_e_Performance.DTOs
{
    public class ProgressDTO 
    {
        public int IdProgress { get; set; }
        public string? Value { get; set; }
        public string? Observation { get; set; }
        public EnumStatus ProgressStatus { get; set; }
    }
}
