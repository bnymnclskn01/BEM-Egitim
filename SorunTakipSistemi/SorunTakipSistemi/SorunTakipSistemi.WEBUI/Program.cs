using Microsoft.AspNetCore.Http.Features;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(1);
});
builder.Services.Configure<FormOptions>(x=>{
    x.MultipartBodyLengthLimit = 25600;
});
var app = builder.Build();
// Configure the HTTP request pipeline.
app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/robots.txt"))
    {
        var robotsTxtPat = Path.Combine(app.Environment.ContentRootPath, "robots.txt");
        string output = "User-agent:*\nAllow: /";
        if (File.Exists(robotsTxtPat))
        {
            output = await File.ReadAllTextAsync(robotsTxtPat);
        }
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAsync(output);
    }
    else await next();
});
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePages("Error/Index", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
