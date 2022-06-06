using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Services.Contracts
{
    public interface ICartService
    {
        Task<List<CartItemDto>> GetItems(int userGuid);
        Task<CartItemDto> AddItem(CartItemToAdd cartItemToAddDto);
        Task<CartItemDto> DeleteItem(int id);
    }
}
