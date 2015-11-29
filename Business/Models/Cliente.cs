using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public Cliente()
        {
            Apolices = new List<Apolice>();
        }

        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [CustomValidation.CustomValidationCPF(ErrorMessage = "CPF inválido!")]
        public string CPF { get; set; }

        [Display(Name = "RG")]
        public string RG { get; set; }

        [Display(Name = "Orgão Emissor")]
        public string RGOrgaoEmissor { get; set; }

        [Display(Name = "Data de Emissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RGDataEmissao { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Nacionalidade")]
        public string Nacionalidade { get; set; }

        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivilCliente { get; set; }

        [Display(Name = "Profissão")]
        public string Profissao { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Nº")]
        public string Numero { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        public string UF { get; set; }

        public virtual ICollection<Apolice> Apolices { get; set; }


        public enum EstadoCivil
        {
            [Description("Solteiro(a)")]
            SOLTEIRO = 1,
            [Description("Casado(a)")]
            CASADO,
            [Description("Divorciado(a)")]
            DIVORCIADO,
            [Description("Viúvo(a)")]
            VIUVO
        }

    }
}
