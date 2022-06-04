using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacare.Models.Dtos
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int DrugId { get; set; }
        public int Quantity { get; set; }
        public string DrugName { get; set; }
        public string DrugImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
