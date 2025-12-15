using Gestão_de_metas_e_Performance.Models;

namespace Gestão_de_metas_e_Performance.Models
{
    public class Progress : Meta
    {
        
        public string? Value { get; set; }
        public string? Observation { get; set; }
        public EnumStatus ProgressStatus { get; set; }
    }
}
