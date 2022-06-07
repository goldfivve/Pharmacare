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

        public async Task<IEnumerable<ActiveSubstance>> GetActiveSubstances()
        {
            var activeSubstances = await this._pharmacareDbContext.ActiveSubstances.ToListAsync();

            return activeSubstances;
        }

        public async Task<Drug> GetDrugById(int id)
        {
            var drug = await _pharmacareDbContext.Drugs.FindAsync(id);
            return drug;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var category = await _pharmacareDbContext.Categories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<ActiveSubstance> GetActiveSubstanceById(int id)
        {
            var substance = await _pharmacareDbContext.ActiveSubstances.SingleOrDefaultAsync(a => a.SubstanceId == id);
            return substance;
        }

        public async Task<IEnumerable<Drug>> GetItemsByCategory(int id)
        {
            var drugs = await (from drug in _pharmacareDbContext.Drugs
                where drug.CategoryId == id
                select drug).ToListAsync();
            return drugs;
        }
    }
}
