using Microsoft.EntityFrameworkCore;
using Web_API.Models;
using Web_API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<_DbContext>(x => x.UseSqlServer(
    
        builder.Configuration.GetConnectionString("DefaultConnectionSqlServer")//, <== Usando SQL Server
        //builder.Configuration.GetConnectionString("DefaultConnectionMySql"), <== Usando MySql
        //ServerVersion.Parse("10.4.22")
    ));

// Injeção da dependência do repositorio
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
