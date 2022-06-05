using Microsoft.AspNetCore.Components;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class DrugsBase : ComponentBase
    {
        [Inject]
        public IDrugService DrugService { get; set; }

        public IEnumerable<DrugDto> Drugs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Drugs = await DrugService.GetItems();
        }

        protected IOrderedEnumerable<IGrouping<int, DrugDto>> GetGroupedDrugsByCategory()
        {
            return from drug in Drugs
                group drug by drug.CategoryId
                into drugByCategoryGroup
                orderby drugByCategoryGroup.Key
                select drugByCategoryGroup;
        }

        protected string GetCategoryName(IGrouping<int, DrugDto> groupedDrugDtos)
        {
            return groupedDrugDtos.FirstOrDefault(dg => dg.CategoryId == groupedDrugDtos.Key).CategoryName;

        }
    }
}
