using HR.EMS.Application.Configurations;
using HR.EMS.Infrastructure.Middlewares;
using HR.EMS.Infrastructure.ExtensionInfrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuration Settings
ApplicationSettings application = new();
builder.Services.AddSingleton(application);
// Add Custom Infrastructure
builder.Services.AddPersistenceInfrastructure(ApplicationSettings: application);
//Configure JWT Authentication
builder.Services.AddCustomJwtAuthentication(tokenSecret: application.TokenSecret);
//Create Authorization Policies
builder.Services.AddCustomAuthorizationPolicies();
// Configure Serilog for logging
builder.Services.AddCustomSerilogLogging(application.FileLogsPath);




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

//app.UseMiddleware<JwtTokenValidationMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.UseMiddleware<RequestResponseMiddleware>();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.Run();
