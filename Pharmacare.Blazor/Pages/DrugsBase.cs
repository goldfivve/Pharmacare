using Microsoft.AspNetCore.Components;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class DrugsBase : ComponentBase
    {
        [Inject]
        public IDrugService DrugService { get; set; }

        [Inject]
        public ICartService CartService { get; set; }

        public IEnumerable<DrugDto> Drugs { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Drugs = await DrugService.GetItems();

                var cartItems = await CartService.GetItems(HardCoded.UserGuid);
                var totalQuantity = cartItems.Sum(i => i.Quantity);

                CartService.RaiseEventOnCartChanged(totalQuantity);

            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
            
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
