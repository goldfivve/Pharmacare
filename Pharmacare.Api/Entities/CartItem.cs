using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Entities
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int CartId { get; set; }
        public int DrugId { get; set; }
        public int Quantity { get; set; }
    }
}
