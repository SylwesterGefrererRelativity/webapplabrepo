var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var configuration = (IConfiguration) app.Services.GetService(typeof(IConfiguration))!;

app.MapGet("/", () => "FAILING TEST!");

app.Run();
