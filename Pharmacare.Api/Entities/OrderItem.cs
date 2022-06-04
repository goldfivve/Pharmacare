using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Entities
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DrugId { get; set; }
        public int Quantity { get; set; }
    }
}
