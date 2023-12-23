using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args).Inject();

builder.Services.AddBootstrapBlazor();
// Add services to the container.
builder.Services.AddRazorPages().AddInjectBase();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseInjectBase();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
