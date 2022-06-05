using Pharmacare.Entities;

namespace Pharmacare.Api.Repositories.Contracts
{
    public interface IDrugRepository
    {
        Task<IEnumerable<Drug>> GetItems();
        Task<IEnumerable<Category>> GetCategories();
        Task<IEnumerable<ActiveSubstance>> GetActiveSubstances();
        Task<Drug> GetDrugById(int id);
        Task<Category> GetCategoryById(int id);
        Task<ActiveSubstance> GetActiveSubstanceById(int id);
    }
}
