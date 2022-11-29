using El_Tamayez.Models;
using Graduation_Project.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ISubjectRepositry, SubjectRepositry>();
builder.Services.AddScoped<IStudentRepositry, StudentRepositry>();
builder.Services.AddScoped<IRegisterRepositry, RegisterRepositry>();
builder.Services.AddScoped<ITeacherRepositry, TeacherRepositry>();
builder.Services.AddScoped<IContactusRepositry,ContactsusRepositry>();
builder.Services.AddDbContext<CenterDBContext>(
    n => 
    { n.UseSqlServer("Server=DESKTOP-S9RDLNO\\MSSQLSERVER2;Database=ElTamayezDB;Trusted_Connection=True;"); }
    );
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
