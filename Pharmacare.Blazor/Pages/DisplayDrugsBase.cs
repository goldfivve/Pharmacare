using Microsoft.AspNetCore.Components;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Blazor.Pages
{
    public class DisplayDrugsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<DrugDto> Drugs { get; set; }


    }
}
