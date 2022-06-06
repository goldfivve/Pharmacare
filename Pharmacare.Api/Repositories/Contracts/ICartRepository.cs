using Pharmacare.Entities;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Api.Repositories.Contracts
{
    public interface ICartRepository
    {
        Task<CartItem> AddItem(CartItemToAdd cartItemToAddDToAdd);
        Task<CartItem> UpdateQuantity (int id, CartItemQuantityUpdateDto quantityUpdateDto);
        Task<CartItem> DeleteItem(int id);
        Task<CartItem> GetItem (int id);
        Task<IEnumerable<CartItem>> GetItems (Guid userGuid);
    }
}
