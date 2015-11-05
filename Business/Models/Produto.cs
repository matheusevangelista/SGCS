using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    [Table("Produto")]
    public class Produto
    {
        public Produto()
        {
            Apolices = new List<Apolice>();
        }

        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public virtual ICollection<Apolice> Apolices { get; set; }

    }
}
