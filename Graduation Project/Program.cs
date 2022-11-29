using Graduation_Project.Models;
using Graduation_Project.AdminRepository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CenterDBContext>(
    n => 
    { n.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ElTamayezDB;Trusted_Connection=True;"); }
    );
builder.Services.AddScoped<IRegister, RegisterRepository>();
builder.Services.AddScoped<IContactUs, ContactUsRepository>();
builder.Services.AddScoped<IGroup, GroupRepository>();
builder.Services.AddScoped<ISubject, SubjectRepository>();
builder.Services.AddScoped<ITeacher, TeacherRepository>();
builder.Services.AddScoped<IStudent, StudentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "areas",
               pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
