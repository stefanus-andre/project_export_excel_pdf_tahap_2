using Rotativa.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

RotativaConfiguration.Setup(app.Environment.ContentRootPath, "Rotativa");

app.UseAuthorization();
app.MapDefaultControllerRoute();
app.Run();