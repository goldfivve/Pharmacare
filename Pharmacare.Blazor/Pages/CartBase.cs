using Microsoft.AspNetCore.Components;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class CartBase : ComponentBase
    {
        [Inject]
        public ICartService CartService { get; set; }

        public List<CartItemDto> CartItems { get; set; }

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

        protected async Task DeleteCartIemClick(int id)
        {
            var cartItemDto = await CartService.DeleteItem(id);

            RemoveCartItem(id);
        }

        private CartItemDto GetCartItem(int id)
        {
            return CartItems.FirstOrDefault(i => i.Id == id);
        }

        private void RemoveCartItem(int id)
        {
            var cartItemDto = GetCartItem(id);

            CartItems.Remove(cartItemDto);
        }
    }
}
