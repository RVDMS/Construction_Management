using Microsoft.OpenApi.Models;
using RVDMS.Application;
using RVDMS.Infrastructure;
using RVDMS.Infrastructure.Seeders.MasterSeeder;
using Serilog;
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.0.0",
        Title = "RVDMS API",
        Description = @"
            <strong>🏛️ Regional Visual Dashboard Management System</strong><br/>
            Official API for the State Department for Housing and Urban Development.
            
            <h3>🔑 Key Features:</h3>
            <ul>
                <li><strong>Projects:</strong> AHP, ESP Markets, Institutional Housing, Urban Development</li>
                <li><strong>Progress Tracking:</strong> Physical progress, time elapsed, variance analysis</li>
                <li><strong>Geo-Validation:</strong> Location-based report verification</li>
                <li><strong>Role-Based Access:</strong> RL, TL, CS, CDH, COW, SuperAdmin</li>
                <li><strong>Real-time Analytics:</strong> Project status, delays, completions</li>
            </ul>

            <h3>📋 Implementation Notes:</h3>
            <ul>
                <li>All endpoints require authentication via Bearer token</li>
                <li>Responses are paginated with metadata</li>
                <li>Dates are returned in ISO 8601 format (UTC)</li>
                <li>Progress values are percentages (0-100)</li>
            </ul>

            <h3>📞 Support:</h3>
            <ul>
                <li>Technical Support: <a href='mailto:support@rvdms.go.ke'>support@rvdms.go.ke</a></li>
                <li>Documentation: <a href='https://docs.rvdms.go.ke'>https://docs.rvdms.go.ke</a></li>
                <li>Status Page: <a href='https://status.rvdms.go.ke'>https://status.rvdms.go.ke</a></li>
            </ul>
        ",
        TermsOfService = new Uri("https://rvdms.go.ke/terms"),
        Contact = new OpenApiContact
        {
            Name = "RVDMS Technical Team",
            Email = "support@rvdms.go.ke",
            Url = new Uri("https://rvdms.go.ke")
        },
        License = new OpenApiLicense
        {
            Name = "Government Open Data License v1.0",
            Url = new Uri("https://rvdms.go.ke/license")
        }
    });
});
builder.Host.UseSerilog();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            options.RoutePrefix = "swagger";
        }
    });
    using var scope = app.Services.CreateScope();
    var initializer = scope.ServiceProvider.GetRequiredService<DbInitializer>();
    await initializer.SeedAsync();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
