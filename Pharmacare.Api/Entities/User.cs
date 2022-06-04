using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; init; }
        public string Name { get; init; }
    }
}
