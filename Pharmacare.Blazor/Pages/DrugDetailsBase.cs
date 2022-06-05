using Microsoft.AspNetCore.Components;
using Pharmacare.Blazor.Services.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class DrugDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IDrugService DrugService { get; set; }

        public DrugDto Drug { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Drug = await DrugService.GetDrug(Id);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
