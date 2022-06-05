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
                var drugs = await _httpClient.GetFromJsonAsync<IEnumerable<DrugDto>>("api/Drug");
                return drugs;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
