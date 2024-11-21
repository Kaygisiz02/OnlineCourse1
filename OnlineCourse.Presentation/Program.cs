using Microsoft.EntityFrameworkCore;
using OnlineCourse.Entity;
using OnlineCourse.Presentation.Extansions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapperCustom();
builder.Services.AddCustomRepository();
builder.Services.AddCustomServices();
/*builder.Services.AddSession();*///Session kullanmak için eklenmelidir
builder.Services.AddDbContext<OnlineCourseDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
});
var app = builder.Build();

app.MapControllerRoute
    (
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
