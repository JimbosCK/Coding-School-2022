
using FuelStation.Blazor.Shared.Services;
using FuelStation.EF.Context;
using FuelStation.EF.Repositories;
using FuelStation.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationContext>();

builder.Services.AddScoped<IEntityRepo<Item>, ItemRepo>();
builder.Services.AddScoped<IEntityRepo<Employee>, EmployeeRepo>();
builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
builder.Services.AddScoped<IEntityRepo<Transaction>, TransactionRepo>();
builder.Services.AddScoped<IEntityRepo<TransactionLine>, TransactionLineRepo>();
builder.Services.AddScoped<IEntityRepo<FuelStationShop>, FuelStationShopRepo>();

builder.Services.AddScoped<LoginHandler>();
builder.Services.AddScoped<CustomerHandler>();
builder.Services.AddScoped<EmployeeHandler>();
builder.Services.AddScoped<LedgerHandler>();

// TODO: Refactor FuelStationShop initialization
var context = new ApplicationContext();
var fuelStationRepo = new FuelStationShopRepo(context);
var fuelstation = await fuelStationRepo.GetAllAsync();
if (fuelstation.Count() < 1) { await fuelStationRepo.CreateAsync(new FuelStationShop() { MonthlyRent = 5000 }); }

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
