using Microsoft.AspNetCore.Components;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class CartBase : ComponentBase
    {
        [Inject]
        public ICartService CartService { get; set; }

        public IEnumerable<CartItemDto> CartItems { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                CartItems = await CartService.GetItems(HardCoded.UserGuid);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
