using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
