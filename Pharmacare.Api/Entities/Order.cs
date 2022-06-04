using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; init; }

        public DateTimeOffset DateTime { get; init; }

        public OrderStatus OrderStatus { get; init; }

        public int UserId { get; init; }
    }
}
