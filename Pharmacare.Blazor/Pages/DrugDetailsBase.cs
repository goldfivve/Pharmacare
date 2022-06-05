using Microsoft.AspNetCore.Components;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class DrugDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IDrugService DrugService { get; set; }
        
        [Inject]
        public ICartService CartService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public DrugDto Drug { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Drug = await DrugService.GetDrug(Id);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }

        protected async Task AddToCartClick(CartItemToAdd cartItemToAddDto)
        {
            try
            {
                var cartItemDto = await CartService.AddItem(cartItemToAddDto);
                NavigationManager.NavigateTo("/Cart");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
