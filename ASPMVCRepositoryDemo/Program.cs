using ASPMVCRepositoryDemo.Data;
using ASPMVCRepositoryDemo.Respository;
using ASPMVCRepositoryDemo.Respository.IRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("SalesDBCon")
));

builder.Services.AddScoped<IEmployeesRepo, EmployeeRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();

