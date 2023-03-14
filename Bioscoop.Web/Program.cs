using Bioscoop.Web;
using Bioscoop.Web.Services;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTIyNTk3MkAzMjMwMmUzNDJlMzBoblAzdWVmZkFtSUlNNk5sQVB2SlRvVG9WK0haWUVscjlVY1F3ckN4Tm40PQ==");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7027/") });
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IShowService, ShowService>();
builder.Services.AddScoped<ITicketService, TicketService>();

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7027/") });

builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IMailService, MailService>();
builder.Services.AddLocalization();


builder.Services.AddScoped<IPaymentService, PaymentService>();

await builder.Build().RunAsync();
