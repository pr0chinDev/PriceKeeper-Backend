using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_PriceKeeper.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string priceName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int rate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int amount { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int total { get; set; }
    }
}
