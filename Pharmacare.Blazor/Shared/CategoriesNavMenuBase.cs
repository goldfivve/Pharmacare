using Microsoft.AspNetCore.Components;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class CategoriesNavMenuBase : ComponentBase
    {
        [Inject]
        public IDrugService DrugService { get; set; }
        public IEnumerable<CategoryDto> CategoryDtos { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                CategoryDtos = await DrugService.GetCategories();
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
