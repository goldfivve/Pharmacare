using Microsoft.EntityFrameworkCore;
using Pharmacare.Api.Repositories;
using Pharmacare.Api.Repositories.Contracts;
using Pharmacare.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<PharmacareDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PharmacareConnection")));


builder.Services.AddScoped<IDrugRepository, DrugRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
