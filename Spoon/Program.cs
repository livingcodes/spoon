var builder = WebApplication.CreateBuilder(args);
var svc = builder.Services;
svc.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();
app.MapRazorPages();
app.Run();