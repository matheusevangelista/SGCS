using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    [Table("Apolice")]
    public class Apolice
    {
        [Key]
        public int Id { get; set; }

        public virtual Seguradora Seguradora { get; set; }

    }
}
