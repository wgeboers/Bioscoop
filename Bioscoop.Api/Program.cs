using Bioscoop.Api.Configuration;
using Bioscoop.Api.Services;
using Bioscoop.Api.Data;
using Bioscoop.Api.Repositories;
using Bioscoop.Api.Repositories.Contracts;
using MailKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<BioscoopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BioscoopConnection"))
);

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IShowRepository, ShowRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();

//Pick up mailsettings
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection(nameof(MailSettings)));
builder.Services.AddTransient<Bioscoop.Api.Services.IMailService, Bioscoop.Api.Services.MailService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
           policy.WithOrigins("https://localhost:7027", "https://localhost:7235")
           .AllowAnyMethod()
           .WithHeaders(HeaderNames.ContentType)
           );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
