using System.ComponentModel.DataAnnotations;

namespace Pharmacare.Entities
{
    public class Drug
    {
        [Key]
        public int DrugId { get; init; }

        public string TradeName { get; init; }

        public string Dosage { get; init; }

        public string PackSize { get; init; }

        public string ImageURL { get; init; }

        public decimal Price { get; init; }

        public int CategoryId { get; init; }

        public int Quantity { get; init; }

        public int ActiveSubstanceId { get; init; }

    }
}
