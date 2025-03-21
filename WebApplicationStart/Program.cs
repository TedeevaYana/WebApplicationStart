var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "calculator",
    pattern: "{controller=Home}/{action=calculator}/{a?}/{b?}");

app.MapControllerRoute(
    name: "calculatorpro",
    pattern: "{controller=Home}/{action=calculatorpro}/{a?}/{b?}/{c?}");

app.MapControllerRoute(
    name: "calculatorparametrs",
    pattern: "{controller=Home}/{action=calculatorparametrs}");
app.Run();
