using ArmoredMarineV2.Data;
using ArmoredMarineV2.Handlers;
using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();


builder.Services.AddSingleton<IUserInterface, UserInterfaceManager>();
builder.Services.AddSingleton<IMarine, MarineManager>();
builder.Services.AddSingleton<StrengthStatButtonHandler>();


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
