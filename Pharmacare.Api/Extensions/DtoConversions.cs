﻿using Pharmacare.Entities;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<DrugDto> ConvertToDto(this IEnumerable<Drug> drugs, IEnumerable<Category> drugCategories, IEnumerable<ActiveSubstance> activeSubstances)
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
    }
}