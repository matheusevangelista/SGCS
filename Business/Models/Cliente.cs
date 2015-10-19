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
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string RGOrgaoEmissor { get; set; }

        public DateTime RGDataEmissao { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Nacionalidade { get; set; }

        public string Profissao { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }


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
