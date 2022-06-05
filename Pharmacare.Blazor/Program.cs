using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Pharmacare.Blazor;
using Pharmacare.Blazor.Services;
using Pharmacare.Blazor.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7133/") });
builder.Services.AddScoped<IDrugService, DrugService>();

await builder.Build().RunAsync();
