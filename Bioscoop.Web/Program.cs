using Bioscoop.Web;
using Bioscoop.Web.Services;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7027/") });

//Dependancy injection
builder.Services.AddScoped<IMovieService, MovieService>();

await builder.Build().RunAsync();
