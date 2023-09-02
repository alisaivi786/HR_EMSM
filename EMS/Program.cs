using HR.EMS.Application.Configurations;
using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Infrastructure;
using HR.EMS.Infrastructure.Middlewares;
using HR.EMS.Presistence;
using HR.EMS.Presistence.UnitOfWork;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuration Settings
ApplicationSettings application = new();
builder.Services.AddSingleton(application);
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
// Add Custom Infrastructure
builder.Services.AddInfrastructure(ApplicationSettings: application);
// Add Middleware

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
// Use the custom middleware in the pipeline

app.UseMiddleware<JwtTokenValidationMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");
// Middleware after controller action method (e.g., response logging)
//app.UseMiddleware<RequestResponseLoggingMiddleware>();

app.UseMiddleware<RequestResponseMiddleware>();
app.Run();
