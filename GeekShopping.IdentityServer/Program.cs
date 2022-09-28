
using GeekShopping.IdentityServer.Configuration;
using GeekShopping.IdentityServer.Model.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql("server=localhost; database=geek_shopping_identity_server;uid=root;pwd=dias0502", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql")));
builder.Services.AddIdentity<ApplicationUser,IdentityRole>().AddEntityFrameworkStores<MySQLContext>().
    AddDefaultTokenProviders();
var builders = builder.Services.AddIdentityServer(options =>
{
    options.Events.RaiseErrorEvents = true;
    options.Events.RaiseInformationEvents = true;
    options.Events.RaiseFailureEvents = true;
    options.Events.RaiseSuccessEvents = true;
    options.EmitStaticAudienceClaim = true;
}).AddInMemoryApiResources
((IConfigurationSection)IdentityConfiguration.IdentityResource).AddInMemoryClients(IdentityConfiguration.Clients).
AddAspNetIdentity<ApplicationUser>();
builders.AddDeveloperSigningCredential();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
