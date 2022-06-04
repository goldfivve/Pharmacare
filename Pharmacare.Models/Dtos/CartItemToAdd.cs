using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacare.Models.Dtos
{
    public class CartItemToAdd
    {
        public int CartId { get; set; }
        public int DrugId { get; set; }
        public int Quantity { get; set; }
    }
}
