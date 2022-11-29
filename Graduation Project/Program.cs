<<<<<<< HEAD
using Graduation_Project.Models;
using Graduation_Project.AdminRepository;
=======
using El_Tamayez.Models;
<<<<<<< HEAD
using Graduation_Project.Repository;
=======
using El_Tamayez.Repository;
>>>>>>> ca754856c75128b1668ee6b51bd7ffaef5f7dc6e
>>>>>>> 68eba0c44bb32fd5f02e09ca216dac8392b2062b
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
<<<<<<< HEAD
    { n.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ElTamayezDB;Trusted_Connection=True;"); }
    );
builder.Services.AddScoped<IRegister, RegisterRepository>();
builder.Services.AddScoped<IContactUs, ContactUsRepository>();
builder.Services.AddScoped<IGroup, GroupRepository>();
builder.Services.AddScoped<ISubject, SubjectRepository>();
builder.Services.AddScoped<ITeacher, TeacherRepository>();
builder.Services.AddScoped<IStudent, StudentRepository>();

=======
    { n.UseSqlServer("Server=DESKTOP-S9RDLNO\\MSSQLSERVER2;Database=ElTamayezDB;Trusted_Connection=True;"); }
    );
builder.Services.AddScoped<IPostRepository , PostRepository>();
>>>>>>> 68eba0c44bb32fd5f02e09ca216dac8392b2062b
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
