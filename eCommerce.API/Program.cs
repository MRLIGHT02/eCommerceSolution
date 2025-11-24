using eCommerce.API.MiddleWare;
using eCommerce.Core;
using eCommerce.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddInfrastructure();
builder.Services.AddCore();
builder.Services.AddControllers();

var app = builder.Build();
// Route

app.UseExceptionHandlingMiddleware();
app.UseRouting();

// Auth
app.UseAuthentication();
app.UseAuthorization();
// Map Controllers
app.MapControllers();

app.Run();
