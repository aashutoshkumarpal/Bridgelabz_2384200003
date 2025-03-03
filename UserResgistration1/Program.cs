using BusinessLayer1.Interface;
using BusinessLayer1.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;
using RepositoryLayer1.Context;
using RepositoryLayer1.Interface;
using RepositoryLayer1.Service;

var logger = LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();
logger.Info("Application is starting...");

var builder = WebApplication.CreateBuilder(args);

// Configure NLog
builder.Logging.ClearProviders();
builder.Host.UseNLog();

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddScoped<IUserRegistrationBL, UserRegistrationBL>();
builder.Services.AddScoped<IUserRegistrationRL, UserRegistrationRL>();

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(connectionString));

// Swagger Configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

try
{
    logger.Info("Application is running...");
    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application encountered a critical error.");
}
finally
{
    LogManager.Shutdown();
}
