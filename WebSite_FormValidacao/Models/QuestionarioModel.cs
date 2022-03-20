
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebSite_FormValidacao.Models
{
    public class QuestionarioModel
    {
        [Required]
        [DisplayName("Tipo de projeto")]
        public string TipoProjeto { get; set; }

        [Required(ErrorMessage = "Informe o CEP.")]
        [RegularExpression(@"^\d{8}$|^\d{5}-\d{3}$", ErrorMessage = "o Código Postal deverá estar no formato 00000-000 ou 00000000")]
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O nome do contato deve ser informado.")]
        [StringLength(50, MinimumLength = 6)]
        public string Contato { get; set; }

        [Required(ErrorMessage = "Informe o email.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o telefone.")]
        [DataType(DataType.PhoneNumber,ErrorMessage = "Forneça o número de telefone no formato (00)000-0000")]
        [DisplayName("Número de telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe a descrição do projeto.")]
        [DisplayName("Descrição do projeto")]
        [StringLength(5000, MinimumLength =20)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

    }
}