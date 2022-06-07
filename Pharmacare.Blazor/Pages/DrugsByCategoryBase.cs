using Microsoft.AspNetCore.Components;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class DrugsByCategoryBase : ComponentBase
    {
        [Parameter]
        public int CategoryId { get; set; }

        [Inject]
        public IDrugService DrugService { get; set; }

        public IEnumerable<DrugDto> Drugs { get; set; }

        public string CategoryName { get; set; }

        public string ErrorMessage  { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                Drugs = await DrugService.GetItemsByCategory(CategoryId);
                if (Drugs != null && Drugs.Count() > 0)
                {
                    var drugDto = Drugs.FirstOrDefault(d => d.CategoryId == CategoryId);
                    if (drugDto != null)
                    {
                        CategoryName = drugDto.CategoryName;

                    }
                }
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
