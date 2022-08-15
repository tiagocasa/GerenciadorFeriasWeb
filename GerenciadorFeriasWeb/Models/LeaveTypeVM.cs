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
        [Range(1,180, ErrorMessage = "Digite um número válido entre 1 e 180")]
        public int DefaultDays { get; set; }
    }
}
