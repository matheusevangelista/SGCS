using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

       /* [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }*/

        [DataType(DataType.Text)]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Ano")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Ano { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Cor")]
        public string Cor { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Placa")]
        public string Placa { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Combustivel")]
        public string Combustivel { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Renavam")]
        public string Renavam{ get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Chassis")]
        public string Chassis { get; set; }


    }
}
