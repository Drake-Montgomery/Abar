using System.ComponentModel.DataAnnotations;

namespace Abar.Models
{
    public class Pessoa
    {
        public string ? Nome { get; set; }
        public string ? Sobrenome { get; set; }
        public string ? Identidade_de_Genero {get; set; }
        public string ? Orientacao_Sexual { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        [Required(ErrorMessage = "Escolha um arquivo para o subir.")]
        public string ? file { get; set; }
    }
}
