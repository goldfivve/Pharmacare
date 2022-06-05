using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Services.Contracts
{
    public interface ICartService
    {
        Task<IEnumerable<CartItemDto>> GetItems(Guid userGuid);
        Task<CartItemDto> AddItem(CartItemToAdd cartItemToAddDto);
    }
}
