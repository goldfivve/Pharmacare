using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Services.Contracts
{
    public interface IDrugService
    {
        Task<IEnumerable<DrugDto>> GetItems();
        Task<DrugDto> GetDrug(int id);
        Task<IEnumerable<CategoryDto>> GetCategories();
        Task<IEnumerable<DrugDto>> GetItemsByCategory(int categoryId);
    }
}
