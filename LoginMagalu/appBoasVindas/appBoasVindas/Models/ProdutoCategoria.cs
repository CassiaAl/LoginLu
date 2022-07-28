using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appBoasVindas.Models
{
    [Table("tb_product_category")]
    public class ProdutoCategoria
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("productId")]
        [Display(Name = "Código Produto")]
        public int productId { get; set; }

        [Column("categoryId")]
        [Display(Name = "Categoria")]
        public int categoryId { get; set; }




    }
}
