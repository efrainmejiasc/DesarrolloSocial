using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using DesarrolloSocialModelo.Repositories;
using DesarrolloSocialNegocio.Interfaces;
using DesarrolloSocialNegocio.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyAppContext>(op => op.UseSqlServer(@"Server=EMCSERVERASUS\SQLEXPRESS;DataBase=DesarrolloSocial;User Id=sa;Password=1234santiago;MultipleActiveResultSets=false;Connection Timeout=120;TrustServerCertificate=True;",
                                                      b => b.MigrationsAssembly("DesarrolloSocialModelo")));

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

builder.Services.AddScoped<MyAppContext, MyAppContext>();
builder.Services.AddScoped<IGestoresService, GestoresService>();
builder.Services.AddScoped<IGestoresRerpository, GestoresRepository>();
