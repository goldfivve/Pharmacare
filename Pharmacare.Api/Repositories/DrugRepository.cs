using Microsoft.EntityFrameworkCore;
using Pharmacare.Api.Repositories.Contracts;
using Pharmacare.Data;
using Pharmacare.Entities;

namespace Pharmacare.Api.Repositories
{
    public class DrugRepository : IDrugRepository
    {
        private readonly PharmacareDbContext _pharmacareDbContext;

        public DrugRepository(PharmacareDbContext pharmacareDbContext)
        {
            this._pharmacareDbContext = pharmacareDbContext;
        }
        public async Task<IEnumerable<Drug>> GetItems()
        {
            var drugs = await this._pharmacareDbContext.Drugs.ToListAsync();

            return drugs;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = await this._pharmacareDbContext.Categories.ToListAsync();

            return categories;
        }

        public Task<Drug> GetDrugById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Drug> GetCategoryById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
