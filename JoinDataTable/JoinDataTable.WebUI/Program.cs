var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddSession(options =>
{
	options.IdleTimeout=TimeSpan.FromDays(1);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=MultiModel}/{ID?}");
app.MapControllerRoute(
	name : "productList",
	pattern : "{controller=Home}/{action=ProductList}/{ID?}");
app.MapControllerRoute(
    name: "productCreate",
    pattern: "{controller=Home}/{action=ProductCreate}/{ID?}");
app.MapControllerRoute(
    name: "productEdit",
    pattern: "{controller=Home}/{action=PorudctEdit}/{ID?}");
app.MapControllerRoute(
    name: "productDelete",
    pattern: "{controller=Home}/{action=PorudctDelete}/{ID?}");
app.Run();
