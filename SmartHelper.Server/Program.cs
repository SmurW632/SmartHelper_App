using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartHelper.Server.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var configDb = new ConfigDb();
configDb.StartDb();

using (ApplicationDbContext db = new ApplicationDbContext(configDb.Options))
{
    
}

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
