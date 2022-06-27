using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CatalogoVeiculos.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe a placa do veículo")]
        [StringLength(maximumLength:7, MinimumLength =7, ErrorMessage ="Placa do veículo deve possuir 7 caracteres.")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Informe o renavam do veículo")]
        public string Renavam { get; set; }
        [Display(Name ="Nome do Proprietário")]
        [Required(ErrorMessage = "Informe o nome do proprietário do veículo")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o CPF do proprietário do veículo")]
        [StringLength(maximumLength: 11, ErrorMessage = "CPF inválido.")]
        public string CPF { get; set; }        
        public byte[] Imagem { get; set; }
        public bool Bloqueado { get; set; }
    }
}
