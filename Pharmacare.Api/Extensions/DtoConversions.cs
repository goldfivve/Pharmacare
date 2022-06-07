using Pharmacare.Entities;
using Pharmacare.Models.Dtos;
using Category = Pharmacare.Entities.Category;

namespace Pharmacare.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<CategoryDto> ConvertToDto(this IEnumerable<Category> categories)
        {
            return (from category in categories
                select new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name

                }).ToList();
        }

        public static IEnumerable<DrugDto> ConvertToDto(this IEnumerable<Drug> drugs,
            IEnumerable<Category> drugCategories, IEnumerable<ActiveSubstance> activeSubstances)
        {
            return (from drug in drugs
                join drugCategory in drugCategories on drug.CategoryId equals drugCategory.Id
                join activeSubstance in activeSubstances on drug.ActiveSubstanceId equals activeSubstance.SubstanceId
                select new DrugDto
                {
                    DrugId = drug.DrugId,
                    ActiveSubstanceId = drug.ActiveSubstanceId,
                    ActiveSubstanceName = activeSubstance.Name,
                    CategoryId = drugCategory.Id,
                    CategoryName = drugCategory.Name,
                    Dosage = drug.Dosage,
                    ImageURL = drug.ImageURL,
                    PackSize = drug.PackSize,
                    Price = drug.Price,
                    Quantity = drug.Quantity,
                    TradeName = drug.TradeName
                }).ToList();
        }

        public static DrugDto ConvertToDto(this Drug drug, Category drugCategory, ActiveSubstance activeSubstance)
        {
            return new DrugDto
            {
                DrugId = drug.DrugId,
                ActiveSubstanceId = drug.ActiveSubstanceId,
                ActiveSubstanceName = activeSubstance.Name,
                CategoryId = drugCategory.Id,
                CategoryName = drugCategory.Name,
                Dosage = drug.Dosage,
                ImageURL = drug.ImageURL,
                PackSize = drug.PackSize,
                Price = drug.Price,
                Quantity = drug.Quantity,
                TradeName = drug.TradeName
            };
        }

        public static IEnumerable<CartItemDto> ConvertToDto(this IEnumerable<CartItem> cartItems,
            IEnumerable<Drug> drugs)
        {
            return (from cartItem in cartItems
                join drug in drugs
                    on cartItem.DrugId equals drug.DrugId
                select new CartItemDto
                {
                    Id = cartItem.Id,
                    DrugId = drug.DrugId,
                    CartId = cartItem.CartId,
                    DrugImageURL = drug.ImageURL,
                    DrugName = drug.TradeName,
                    Price = drug.Price,
                    Quantity = cartItem.Quantity,
                    TotalPrice = drug.Price * cartItem.Quantity

                }).ToList();
        }
        public static CartItemDto ConvertToDto(this CartItem cartItem,
            Drug drug)
        {
            return new CartItemDto
                {
                    Id = cartItem.Id,
                    DrugId = drug.DrugId,
                    CartId = cartItem.CartId,
                    DrugImageURL = drug.ImageURL,
                    DrugName = drug.TradeName,
                    Price = drug.Price,
                    Quantity = cartItem.Quantity,
                    TotalPrice = drug.Price * cartItem.Quantity

                };
        }
    }
}