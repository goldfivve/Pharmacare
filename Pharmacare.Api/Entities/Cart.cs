using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Entities
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int UserGuid { get; set; }
    }
}
