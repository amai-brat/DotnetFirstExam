using UI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBusinessLogicClient, BusinessLogicClient>(_ =>
    new BusinessLogicClient(builder.Configuration["BusinessLogicUrl"]
                            ?? throw new Exception("There is not url for business logic in configuration file")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=DndCombat}/{action=Index}/{id?}");

app.Run();