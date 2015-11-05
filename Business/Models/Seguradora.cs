using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    [Table("Seguradora")]
    public class Seguradora
    {
        public Seguradora()
        {
            Apolices = new List<Apolice>();
        }

        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual ICollection<Apolice> Apolices { get; set; }

    }
}
