using Microsoft.EntityFrameworkCore;
using Treino_MVC.Context;
using Treino_MVC.Repository;
using Treino_MVC.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddTransient<INoticiaRepository, NoticiaRepository>();
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(connection));

builder.Services.AddTransient<INoticiaRepository, NoticiaRepository>();
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
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
