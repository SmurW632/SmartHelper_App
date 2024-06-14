using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartHelper.Server.Data;
using SmartHelper.Server.Data.Repositories;
using SmartHelper.Server.Interfaces;
using SmartHelper.Server.Models.Auth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IRepository<AuthUser> userRepository = new AuthUserRepository();


var user1 = new AuthUser
{
    Role = "Admin",
    FirstName = "Alice",
    LastName = "Smith",
    MiddleName = "M",
    Email = "alice@example.com",
    Password = "password123",
    Inn = "1234567890",
    Country = "USA",
    City = "New York",
    NameOfOrganization = "ABC Company",
    Post = "Manager",
    WebsiteOrganization = "www.abccompany.com",
    TypeOfIndustry = "Technology",
};

userRepository.Add(user1);


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
