using System.ComponentModel.DataAnnotations;

namespace GerenciadorFeriasWeb.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome da Ausência")]
        public string Name { get; set; }
        [Display(Name = "Dias de Ausência")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
