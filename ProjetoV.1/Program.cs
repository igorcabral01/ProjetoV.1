using Microsoft.EntityFrameworkCore;
using ProjetoV._1.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RangoDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Rangodbconstr")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
