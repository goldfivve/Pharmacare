using Pharmacare.Entities;

namespace Pharmacare.Api.Repositories.Contracts
{
    public interface IDrugRepository
    {
        Task<IEnumerable<Drug>> GetItems();
        Task<IEnumerable<Category>> GetCategories();
        Task<Drug> GetDrugById(Guid id);
        Task<Drug> GetCategoryById(Guid id);
    }
}
