using AUT02_04Discos.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//A�adir el servicio para la inyecci�n de dependencia
builder.Services.AddDbContext<ChinookContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ChinookContext")
    ?? throw new InvalidOperationException("Connetions strings 'ChinookContext' not found.")));

//Registrar servivio identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ChinookContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//invocar autenticacion y autorizacion
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//definir uso maprazorpages
app.MapRazorPages();
app.Run();
