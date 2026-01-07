var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Mày Béo");
app.MapGet("/about", () => "Mày Béo x2");

app.Run();
