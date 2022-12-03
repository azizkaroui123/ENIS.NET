using ENISNC;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ENISNC.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ENISNCContextConnection") ?? throw new InvalidOperationException("Connection string 'ENISNCContextConnection' not found.");
// Add services to the contaivner.
builder.Services.AddDbContext<ENISNCContext>();

builder.Services.AddDefaultIdentity<ENISNCUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ENISNCContext>();
builder.Services.AddControllers();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
