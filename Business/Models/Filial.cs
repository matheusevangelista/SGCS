using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    [Table("Filial")]
    public class Filial
    {
        public Filial()
        {
            Apolices = new List<Apolice>();
        }
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Rua")]
        public string Rua { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Numero")]
        public string Numero { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        public virtual ICollection<Apolice> Apolices { get; set; }
    }
}
