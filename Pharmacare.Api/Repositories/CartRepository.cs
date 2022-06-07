using Microsoft.EntityFrameworkCore;
using Pharmacare.Api.Repositories.Contracts;
using Pharmacare.Data;
using Pharmacare.Entities;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Api.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly PharmacareDbContext _context;

        public CartRepository(PharmacareDbContext context)
        {
            _context = context;
        }

        private async Task<bool> CartItemExists(int cardId, int drugId)
        {
            return await _context.CartItems.AnyAsync(c => c.CartId == cardId && c.DrugId == drugId);
        }

        public async Task<CartItem> AddItem(CartItemToAdd cartItemToAddDToAdd)
        {
            if (await CartItemExists(cartItemToAddDToAdd.CartId, cartItemToAddDToAdd.DrugId) == false)
            {
                var item = await (from drug in _context.Drugs
                    where drug.DrugId == cartItemToAddDToAdd.DrugId
                    select new CartItem
                    {
                        DrugId = drug.DrugId,
                        CartId = cartItemToAddDToAdd.CartId,
                        Quantity = cartItemToAddDToAdd.Quantity
                    }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await _context.CartItems.AddAsync(item);
                    await _context.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;
        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await _context.CartItems.FindAsync(id);

            if (item != null)
            {
                _context.CartItems.Remove(item);
                await _context.SaveChangesAsync();
            }

            return item;
        }

        public async Task<CartItem> UpdateQuantity(int id, CartItemQuantityUpdateDto quantityUpdateDto)
        {
            var item = await _context.CartItems.FindAsync(id);

            if (item != null)
            {
                item.Quantity = quantityUpdateDto.Quantity;
                await _context.SaveChangesAsync();
                return item;
            }

            return null;
        }
        
        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in _context.Carts
                join cartItem in _context.CartItems
                    on cart.Id equals cartItem.CartId
                where cartItem.Id == id
                select new CartItem
                {
                    Id = cartItem.Id,
                    CartId = cartItem.CartId,
                    DrugId = cartItem.DrugId,
                    Quantity = cartItem.Quantity

                }).SingleOrDefaultAsync() ?? throw new InvalidOperationException();
        }

        public async Task<IEnumerable<CartItem>> GetAllItems(int userGuid)
        {
            return await (from cart in _context.Carts
                join cartItem in _context.CartItems
                    on cart.Id equals cartItem.CartId
                where cart.UserGuid == userGuid
                select new CartItem
                {
                    Id = cartItem.Id,
                    CartId = cartItem.CartId,
                    DrugId = cartItem.DrugId,
                    Quantity = cartItem.Quantity
                }).ToListAsync();
        }
    }
}
