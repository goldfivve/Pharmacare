using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Api.Entities
{
    public class User
    {
        [Key]
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
