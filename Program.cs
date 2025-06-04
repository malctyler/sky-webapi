using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using sky_webapi;
using sky_webapi.Data;
using sky_webapi.Data.Entities;
using sky_webapi.Repositories;
using sky_webapi.Services;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configure EmailSettings
builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

// Add Identity services
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => {
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

// Add JWT Authentication with enhanced debugging
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]!)),
        ClockSkew = TimeSpan.Zero // Remove clock skew to make token expiration exact
    };
});

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy => policy
            .WithOrigins(
                "https://witty-plant-0550d6403.6.azurestaticapps.net",
                "http://localhost:3000",
                "https://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .SetIsOriginAllowed(_ => true)); // Allow any origin temporarily for debugging
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
            sqlOptions.CommandTimeout(300); // Set command timeout to 5 minutes
        }));
builder.Services.AddScoped<ISummaryRepository, SummaryRepository>();
builder.Services.AddScoped<ISummaryService, SummaryService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<INoteRepository, NoteRepository>();
builder.Services.AddScoped<INoteService, NoteService>();
builder.Services.AddScoped<IPlantCategoryRepository, PlantCategoryRepository>();
builder.Services.AddScoped<IAllPlantRepository, AllPlantRepository>();
builder.Services.AddScoped<IPlantCategoryService, PlantCategoryService>();
builder.Services.AddScoped<IAllplantervice, Allplantervice>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<IPlantHoldingRepository, PlantHoldingRepository>();
builder.Services.AddScoped<IPlantHoldingService, PlantHoldingService>();
builder.Services.AddScoped<IInspectionRepository, InspectionRepository>();
builder.Services.AddScoped<IInspectionService, InspectionService>();
builder.Services.AddScoped<IInspectorRepository, InspectorRepository>();
builder.Services.AddScoped<IInspectorService, InspectorService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddScoped<IInspectionDueDateRepository, InspectionDueDateRepository>();
builder.Services.AddScoped<IInspectionDueDateService, InspectionDueDateService>();
builder.Services.AddScoped<IScheduledInspectionService, ScheduledInspectionService>();
builder.Services.AddScoped<IScheduledInspectionRepository, ScheduledInspectionRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Sky Web API", Version = "v1" });
    
    // Configure JWT authentication for Swagger
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Enter your token in the text input below.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sky Web API v1");
    c.DocumentTitle = "Sky Web API Documentation";
    c.DefaultModelsExpandDepth(-1); // Hide schemas section by default
});

app.UseHttpsRedirection();

// Apply CORS before authentication
app.UseCors("AllowReactApp");

// Add authentication middleware
app.UseAuthentication();
app.UseAuthorization();

// Enable serving static files and set default files
app.UseDefaultFiles();
app.UseStaticFiles();

// Configure serving files from SecureFiles directory
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "SecureFiles")),
    RequestPath = "/SecureFiles"
});

app.MapGet("/", () => Results.Redirect("/swagger"));

app.MapControllers();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
