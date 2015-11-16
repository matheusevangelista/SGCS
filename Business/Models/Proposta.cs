using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    [Table("Proposta")]
    public class Proposta
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Data Início da Vigência")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataInicioVigencia { get; set; }

        [Display(Name = "Data Fim da Vigência")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataFimVigencia { get; set; }

        [Display(Name = "Número do Endosso")]
        public int NumeroEndosso { get; set; }

        [Display(Name = "Data de Emissão da Proposta")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataEmissaoApolice { get; set; }

        [Display(Name = "Data de Baixa da Proposta")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataBaixaProposta { get; set; }

        [Display(Name = "Número da Proposta na Seguradora")]
        public int NumeroPropostaSeguradora { get; set; }

        [Display(Name = "Valor da Entrada")]
        [DataType(DataType.Currency)]
        public decimal? Entrada { get; set; }

        [Display(Name = "Número de Prestações")]
        public int? NumeroPrestacoes { get; set; }

        [Display(Name = "Valor das Prestações ")]
        [DataType(DataType.Currency)]
        public decimal? ValorPrestacoes { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataPrimeiroVencimento { get; set; }

        public int? ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        public int? VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public virtual Veiculo Veiculo { get; set; }
        
    }
}
