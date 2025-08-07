using Microsoft.EntityFrameworkCore;
using WebApp.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);
    options.EnableSensitiveDataLogging(true);
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

app.MapDefaultControllerRoute();

var context = app.Services.CreateScope().ServiceProvider.GetService<DataContext>();

if (context != null)
{
  await SeedData.SeedDatabase(context);
}

app.Run();