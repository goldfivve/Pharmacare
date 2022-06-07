using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class CartBase : ComponentBase
    {
        [Inject]
        public IJSRuntime Js { get; set; }

        [Inject] public ICartService CartService { get; set; }

        public List<CartItemDto> CartItems { get; set; }

        public string ErrorMessage { get; set; }

        protected string TotalPrice { get; set; }

        protected int TotalQuantity { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                CartItems = await CartService.GetItems(HardCoded.UserGuid);
                CartChanged();
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
            CartChanged();

        }

        protected async Task UpdateQuantityCartItem(int id, int quantity)
        {
            try
            {
                if (quantity > 0)
                {
                    var updateItemDto = new CartItemQuantityUpdateDto
                    {
                        CartItemId = id,
                        Quantity = quantity
                    };

                    var returnedUpdateItemDto = await CartService.UpdateQuantity(updateItemDto);
                    
                    UpdateItemTotalPrice(returnedUpdateItemDto);

                    CartChanged();

                    await MakeUpdateQuantityButtonVisible(id, false);

                }
                else
                {
                    var item = CartItems.FirstOrDefault(i => i.Id == id);

                    if (item != null)
                    {
                        item.Quantity = 1;
                        item.TotalPrice = item.Price;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        protected async Task UpdateQuantityInput(int id)
        {
            await MakeUpdateQuantityButtonVisible(id, true);
        }

        protected async Task MakeUpdateQuantityButtonVisible(int id, bool visible)
        {
            await Js.InvokeVoidAsync("MakeUpdateQuantityButtonVisible", id, visible);
        }

        private void UpdateItemTotalPrice(CartItemDto cartItemDto)
        {
            var item = GetCartItem(cartItemDto.Id);

            if (item != null)
            {
                item.TotalPrice = cartItemDto.Price * cartItemDto.Quantity;
            }
        }

        private void CalculateCartSummaryTotals()
        {
            SetTotalPrice();
            SetTotalQuantity();
        }

        private void SetTotalPrice()
        {
            TotalPrice = CartItems.Sum(p => p.TotalPrice).ToString("C");
        }

        private void SetTotalQuantity()
        {
            TotalQuantity = CartItems.Sum(q => q.Quantity);
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

        private void CartChanged()
        {
            CalculateCartSummaryTotals();
            CartService.RaiseEventOnCartChanged(TotalQuantity);
        }
    }
}