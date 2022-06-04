
namespace Pharmacare.Models.Dtos
{
    public class DrugDto
    {
        public int DrugId { get; init; }

        public string TradeName { get; init; }

        public string Dosage { get; init; }

        public string PackSize { get; init; }

        public string ImageURL { get; init; }

        public decimal Price { get; init; }

        public int CategoryId { get; init; }

        public string CategoryName { get; init; }

        public int Quantity { get; init; }

        public int ActiveSubstanceId { get; init; }

        public string ActiveSubstanceName { get; init; }

    }
}
