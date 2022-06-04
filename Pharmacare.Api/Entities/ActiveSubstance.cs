using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Entities
{
    public class ActiveSubstance
    {
        [Key]
        public int SubstanceId { get; init; }

        public string Name { get; init; }

        public string InternationalName { get; init; }

        public string Description { get; init; }

    }
}
