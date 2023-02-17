using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace XML_Dependency.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? UnitePrice { get; set; }
        public short? UnitInStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
