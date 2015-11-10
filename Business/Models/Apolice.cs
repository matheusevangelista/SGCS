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
    [Table("Apolice")]
    public class Apolice
    {
        [Key]
        public int Id { get; set; }

        public int SeguradoraId { get; set; }

        [ForeignKey("SeguradoraId")]
        public virtual Seguradora Seguradora { get; set; }

        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Produto Produto { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [Display(Name = "Indicação")]
        public string Indicacao { get; set; }

        public int FilialId { get; set; }

        [ForeignKey("FilialId")]
        public virtual Filial Filial { get; set; }

        [Display(Name = "Situação da Apólice")]
        public SituacaoApolice SituacaoDaApolice { get; set; }

        public enum SituacaoApolice
        {
            [Description("Ativa")]
            ATIVA = 1,
            [Description("Cancelada Pelo Segurado")]
            CANCELADA_PELO_SEGURADO,
            [Description("Cancelada Pelo Seguradora")]
            CANCELADA_PELA_SEGURADORA,
            [Description("Cancelada perda Total")]
            CANCELADA_PERDA_TOTAL

        }

    }
}
