using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using studentdatabase.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<studentdatabaseContext>(options =>
    options.UseSqlServer("Server=DESKTOP-D9RJSJF\\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
