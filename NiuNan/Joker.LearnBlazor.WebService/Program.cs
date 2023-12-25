using Joker.LearnBlazor.WebService.Data;
using Joker.LearnBlazor.WebService.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();


// ×¢Èë
builder.Services.AddSingleton<IProduct, ProductRepositoryMssql>();
builder.Services.AddSingleton<ICategory, CategoryRepositoryMssql>();

// ×¢²áAntDesign
builder.Services.AddAntDesign();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
