using System.Text.Json;
using WebApplication2.Model;
using WebApplication2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddTransient<JsonFileZimProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
/***********************
app.MapGet("/products", (context) =>
{
    var products = app.Services.GetService<JsonFileZimProductService>().GetProducts();
    var json = JsonSerializer.Serialize<IEnumerable<ZimProduct>>(products);
    return context.Response.WriteAsync(json);
});***********************/

app.Run();
