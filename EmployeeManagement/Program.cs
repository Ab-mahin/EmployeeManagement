var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

// app.MapDefaultControllerRoute();
// app.UseRouting();  

// app.MapControllerRoute(
//     name:"default",
//     pattern: "{controller=User}/{action=Index}/{id?}"
//     ); 

app.MapControllers();

// app.MapGet("/", () => "Hello World!");

app.Run();
