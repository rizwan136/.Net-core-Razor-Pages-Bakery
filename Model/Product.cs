
using System.ComponentModel.DataAnnotations;

namespace Bakery.Model
{
    public class Product
    {
        public static int Count { get; internal set; }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public string ImageName { get; set; }
    }
}
