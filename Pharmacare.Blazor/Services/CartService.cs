using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Services
{
    public class CartService : ICartService
    {
        private readonly HttpClient _httpClient;

        public event Action<int> OnCartChanged;

        public CartService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CartItemDto>> GetItems(int userGuid)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Cart/{userGuid}/GetItems");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<CartItemDto>().ToList();
                    }

                    return await response.Content.ReadFromJsonAsync<List<CartItemDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<CartItemDto> AddItem(CartItemToAdd cartItemToAddDto)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync<CartItemToAdd>("api/Cart", cartItemToAddDto);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(CartItemDto);
                    }

                    return await response.Content.ReadFromJsonAsync<CartItemDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<CartItemDto> DeleteItem(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"api/Cart/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CartItemDto>();
                }

                return default(CartItemDto);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<CartItemDto> UpdateQuantity(CartItemQuantityUpdateDto cartItemQuantityUpdateDto)
        {
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(cartItemQuantityUpdateDto);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json-patch+json");

                var response = await _httpClient.PatchAsync($"api/Cart/{cartItemQuantityUpdateDto.CartItemId}", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CartItemDto>();
                }

                return null;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            


        }

        public void RaiseEventOnCartChanged(int totalQuantity)
        {
            if (OnCartChanged != null)
            {
                OnCartChanged.Invoke(totalQuantity);
            }
        }
    }
}
