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
{    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true, // Re-enable audience validation
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]!)),
        ClockSkew = TimeSpan.FromSeconds(30) // Reduced from 5 minutes to help identify timing issues
    };
    
    // Debug: Print the JWT settings to console for now
    Console.WriteLine($"JWT Validation - Issuer: {builder.Configuration["JwtSettings:Issuer"]}, Audience: {builder.Configuration["JwtSettings:Audience"]}");

    options.Events = new JwtBearerEvents
    {        OnMessageReceived = context =>
        {            // Try to get the JWT from cookies first
            context.Token = context.Request.Cookies["auth_token"];
            
            // Log what we found
            var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("JWT OnMessageReceived - Found auth_token cookie: {HasToken}", !string.IsNullOrEmpty(context.Token));
            
            if (string.IsNullOrEmpty(context.Token))
            {
                // Fallback to Authorization header
                var authorization = context.Request.Headers.Authorization.ToString();
                if (!string.IsNullOrEmpty(authorization) && authorization.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                {
                    context.Token = authorization.Substring("Bearer ".Length);
                    logger.LogInformation("JWT OnMessageReceived - Found Bearer token in header");
                }
                else
                {
                    logger.LogWarning("JWT OnMessageReceived - No token found in cookie or header");
                }
            }
            return Task.CompletedTask;
        },        OnAuthenticationFailed = context =>
        {
            var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Program>>();
            logger.LogError("JWT Authentication failed: {Exception}", context.Exception.Message);
            logger.LogError("JWT Authentication failed - Full exception: {FullException}", context.Exception.ToString());
              // Log the token that failed (first 20 characters for security)
            var cookieToken = context.Request.Cookies["auth_token"];
            if (!string.IsNullOrEmpty(cookieToken))
            {
                logger.LogWarning("Failed token (first 20 chars): {Token}", cookieToken.Substring(0, Math.Min(20, cookieToken.Length)));
            }
            
            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
            {
                context.Response.Headers.Append("Token-Expired", "true");
                logger.LogWarning("JWT token expired");
            }
            else if (context.Exception.GetType() == typeof(SecurityTokenValidationException))
            {
                logger.LogWarning("JWT token validation failed: {ValidationException}", context.Exception.Message);
            }
            else if (context.Exception.GetType() == typeof(SecurityTokenInvalidSignatureException))
            {
                logger.LogWarning("JWT token has invalid signature");
            }
            
            return Task.CompletedTask;
        }
    };
});

// Add services to the container.
builder.Services.AddCors(options =>
{    options.AddPolicy("AllowReactApp", policy =>
    {        policy.WithOrigins(
                "https://witty-plant-0550d6403.6.azurestaticapps.net",
                "http://localhost:3000",
                "https://localhost:3000",
                "http://localhost:3001",
                "https://localhost:3001"
            )
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .SetIsOriginAllowedToAllowWildcardSubdomains();

        // Add specific headers we want to allow
        policy.WithExposedHeaders("Token-Expired");
    });
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
builder.Services.AddScoped<ICustomerInvoiceService, CustomerInvoiceService>();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddScoped<IInspectionDueDateRepository, InspectionDueDateRepository>();
builder.Services.AddScoped<IInspectionDueDateService, InspectionDueDateService>();
builder.Services.AddScoped<IScheduledInspectionService, ScheduledInspectionService>();
builder.Services.AddScoped<IScheduledInspectionRepository, ScheduledInspectionRepository>();
builder.Services.AddScoped<IPasswordSecurityService, PasswordSecurityService>();

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

// In development, enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sky API V1");
        c.DocExpansion(DocExpansion.None);
    });
}

// Order is important here
app.UseRouting();
app.UseCors("AllowReactApp"); // Must be after UseRouting and before Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Global error handling
app.Use(async (context, next) =>
{
    try
    {
        await next();

        // If we get here, no error occurred
        if (context.Response.StatusCode == 404 && !context.Response.HasStarted)
        {
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(new { Message = "Endpoint not found" });
        }
    }
    catch (Exception ex)
    {
        // Log the error
        var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Unhandled exception");

        // Don't modify response if it has already started
        if (!context.Response.HasStarted)
        {
            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(new { Message = "An error occurred processing your request" });
        }
    }
});

// Configure routing and endpoints
app.UseRouting();
app.MapControllers();

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
