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

app.UseRouting();

app.UseAuthorization();

// When you browse to the application and do not provide any URL segment, it defaults to the "Home" controller and the "Index" method specified in the template line highlighted above.
app.MapControllerRoute(                 
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
