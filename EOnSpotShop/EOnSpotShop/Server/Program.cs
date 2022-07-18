// Using Models of Shared Project
global using EOnSpotShop.Shared.Models;
global using Microsoft.EntityFrameworkCore;
using EOnSpotShop.Server.ShopAppContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ShopContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//Swagger Configuration Step 1

builder.Services.AddEndpointsApiExplorer();

//Swagger Configuration Step 2

builder.Services.AddSwaggerGen();

var app = builder.Build();

//Swagger Configuration Step 3

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


//Swagger Configuration Step 4

app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
