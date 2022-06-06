using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaDevUCDB.Models
{
    public class Pedido
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Produto")]
        public string nome_produto { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Valor")]
        [Range(0, (double)decimal.MaxValue, ErrorMessage = "O valor precisa ser maior do que zero")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "DECIMAL(18, 2)")]
        public decimal valor { get; set; }

        [Display(Name = "Valor")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "DECIMAL(18, 2)")]
        public decimal valor_descontado
        {
            get => valor*(1 - (Desconto / 100));
        }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Data de vencimento")]
        [Column(TypeName = "date")]
        public DateTime data_vencimento { get; set; }

        public string dateForDisplay {
            get => data_vencimento.ToString("dd/MM/yyyy");
        }

        [Display(Name = "Desconto")]
        [Range(0,100, ErrorMessage = "O desconto precisa ser um valor entre 0 e 100")]
        public decimal Desconto { get; set; }

        public string descontoForDisplay
        {
            get => Desconto == 0 ? "-" : Desconto.ToString() + "%";
        }
    }
}
