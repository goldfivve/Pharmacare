using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharmacare.Api.Extensions;
using Pharmacare.Api.Repositories;
using Pharmacare.Api.Repositories.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;
        private readonly IDrugRepository _drugRepository;

        public CartController(ICartRepository cartRepository, IDrugRepository drugRepository)
        {
            _drugRepository = drugRepository;
            _cartRepository = cartRepository;
        }

        [HttpGet]
        [Route("{userGuid}/GetItems")]
        public async Task<ActionResult<IEnumerable<CartItemDto>>> GetItems(Guid userGuid)
        {
            try
            {
                var cartItems = await _cartRepository.GetItems(userGuid);

                if (cartItems == null)
                {
                    return NoContent();
                }

                var drugs = await _drugRepository.GetItems();

                if (drugs == null)
                {
                    throw new Exception("No products exist in the system");
                }

                var cartItemsDto = cartItems.ConvertToDto(drugs);

                return Ok(cartItemsDto);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CartItemDto>> GetItem(int id)
        {
            try
            {
                var cartItem = await _cartRepository.GetItem(id);
                if (cartItem == null)
                {
                    return NotFound();
                }

                var drug = await _drugRepository.GetDrugById(cartItem.DrugId);

                if (drug == null)
                {
                    return NotFound();
                }

                var cartItemDto = cartItem.ConvertToDto(drug);

                return Ok(cartItemDto);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }
        }

        [HttpPost]
        public async Task<ActionResult<CartItemDto>> PostItem([FromBody] CartItemToAdd cartItemToAddDto)
        {
            try
            {
                var newCartItem = await _cartRepository.AddItem(cartItemToAddDto);

                if (newCartItem == null)
                {
                    return NoContent();
                    
                }

                var drug = await _drugRepository.GetDrugById(newCartItem.DrugId);

                if (drug == null)
                {
                    throw new Exception("Something went wrong");
                }

                var newCartItemDto = newCartItem.ConvertToDto(drug);

                return CreatedAtAction(nameof(GetItem), new {id = newCartItemDto.Id}, newCartItemDto);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }
        }

    }
}
