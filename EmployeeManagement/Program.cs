// // using EmployeeManagement.Repository;
//
// var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddControllersWithViews();
// // builder.Services.AddScoped<StudentRepository>();
// var app = builder.Build();
//
// // app.MapDefaultControllerRoute();
// // app.UseRouting();  
//
// app.MapControllerRoute(
//     name:"default",
//     pattern: "{controller=User}/{action=Index}/{id?}"
//     ); 
//
// // app.MapControllers();
//
// // app.MapGet("/", () => "Hello World!");
//
// app.Run();


using EmployeeManagement.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStudent, StudentRepository>();  // Register interface and implementation

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
