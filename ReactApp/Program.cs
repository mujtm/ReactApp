using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;


var policyName = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
                      builder =>
                      {
                          builder
                            .WithOrigins("http://localhost:3000")
                            .AllowAnyOrigin()
                            .WithMethods("GET")
                            .AllowAnyHeader();
                      });
});
// Add services to the container.
builder.Services.AddRazorPages();

// Add dependency injection
builder.Configuration.AddJsonFile("appsettings.json", optional: true);

builder.Services.AddSingleton<IDbConnection>((sp) => new NpgsqlConnection(builder.Configuration.GetConnectionString("PostgreSQL")));

builder.Services.AddScoped<EmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseCors(policyName);

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();