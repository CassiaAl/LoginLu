using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appBoasVindas.Models
{
    [Table("tb_product")]
    public class Produto
    {
      
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }
        [Column("name")]
        [Display(Name = "Nome")]
        public string name { get; set; }

        [Column("price")]
        [Display(Name = "Preço")]
        public decimal price { get; set; }
    }
}
