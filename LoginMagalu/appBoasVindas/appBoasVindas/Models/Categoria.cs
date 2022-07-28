using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appBoasVindas.Models


{
    [Table("tb_category")]
    public class Categoria
    {

       
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("name")]
        [Display(Name = "Nome")]
        public string name { get; set; }

      
    }
}
