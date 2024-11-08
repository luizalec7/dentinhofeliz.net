using System.ComponentModel.DataAnnotations;

namespace DentinhoFeliz.Application.ViewModels
{
    public class CriancaViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }

        [Required]
        [EmailAddress]
        public string EmailResponsavel { get; set; }
    }
}
