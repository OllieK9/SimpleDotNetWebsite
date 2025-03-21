var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Azure! This is a simple .NET website.");

app.Run();
