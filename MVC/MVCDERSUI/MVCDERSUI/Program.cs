var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "action",
    pattern: "{controller=User}/{action=Create}/{id?}"
    );
app.MapControllerRoute(
    name: "action",
    pattern: "{controller=User}/{action=Edit}/{id?}"
    );
app.MapControllerRoute(
    name: "action",
    pattern: "{controller=User}/{action=Delete}/{id?}"
    );

app.Run();
