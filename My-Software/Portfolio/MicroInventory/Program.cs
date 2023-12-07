using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyInventory.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//add this for sqlite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
  options.UseSqlite(builder.Configuration.GetConnectionString("ApplicationDbContext"));
});
//end add this for sqlite




//add this for identity
builder.Services.AddDbContext<UsersDbContext>(options =>
{
  options.UseSqlServer(builder.Configuration.GetConnectionString("UsersDbContext"));
});




builder.Services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<UsersDbContext>()
                .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
  // Default Password settings.
  options.Password.RequireDigit = true;
  options.Password.RequireLowercase = true;
  options.Password.RequireNonAlphanumeric = true;
  options.Password.RequireUppercase = true;
  options.Password.RequiredLength = 6;
  options.Password.RequiredUniqueChars = 1;
}); //change the regex under viewmodel password if changing any of this stuff

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


// New code below!
app.UseAuthentication();
app.UseAuthorization(); //end new code

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Projects}/{action=Index}/{id?}");

app.Run();
