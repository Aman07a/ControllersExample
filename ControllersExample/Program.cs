using ControllersExample.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Adds all the controller classes as services
builder.Services.AddControllers();

var app = builder.Build();

// app.UseStaticFiles();

app.UseRouting();

app.MapControllers();

app.Run();
