using System.Net.Http.Json;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Services
{
    public class DrugService: IDrugService
    {
        private readonly HttpClient _httpClient;

        public DrugService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<DrugDto>> GetItems()
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Drug");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<DrugDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<DrugDto>>();
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

        public async Task<DrugDto> GetDrug(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Drug/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(DrugDto);
                    }

                    return await response.Content.ReadFromJsonAsync<DrugDto>();
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
    }
}
