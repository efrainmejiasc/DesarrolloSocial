using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using DesarrolloSocialModelo.Repositories;
using DesarrolloSocialNegocio.Interfaces;
using DesarrolloSocialNegocio.Services;
using DesarrolloSocialWeb.Filters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

/*builder.Services.AddControllers(config =>
{
    config.Filters.Add(new CustomAuthenticationFilter());
    //config.Filters.Add(new CustomAuthorizationFilter());
});*/

builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages();
builder.Services.AddMvc();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddMvc();
#if DEBUG
builder.Services.AddDbContext<MyAppContext>(
    op => op.UseSqlServer(@"Data Source=SQL8003.site4now.net;Initial Catalog=db_a9308e_desarrollo;User Id=db_a9308e_desarrollo_admin;Password=Bruss12345",
    b => b.MigrationsAssembly("DesarrolloSocialModelo")));
#else
builder.Services.AddDbContext<MyAppContext>(
    op => op.UseSqlServer(@"Data Source=SQL8003.site4now.net;Initial Catalog=db_a9308e_desarrollo;User Id=db_a9308e_desarrollo_admin;Password=Bruss12345",
    b => b.MigrationsAssembly("DesarrolloSocialModelo")));
#endif


builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<MyAppContext, MyAppContext>();
builder.Services.AddScoped<IGestoresService, GestoresService>();
builder.Services.AddScoped<IGestoresRepository, GestoresRepository>();
builder.Services.AddScoped<IDatosPrincipalesRGService, DatosPrincipalesRGService>();
builder.Services.AddScoped<IDatosPrincipalesRGRepository, DatosPrincipalesRGRepository>();
builder.Services.AddScoped<IResponsabledeFamiliaService, ResponsabledeFamiliaService>();
builder.Services.AddScoped<IResponsabledeFamiliaRepository, ResponsabledeFamiliaRepository>();



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
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.UseSession();
app.Run();


