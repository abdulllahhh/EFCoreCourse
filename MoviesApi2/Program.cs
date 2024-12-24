
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using MoviesApi2.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options.UseSqlServer(connectionString: connString)
    
    );
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
        options =>
        {
            options.SwaggerDoc(name: "v1", info: new OpenApiInfo
            {
                Version = "v1",
                Title = "TestApi",
                Description = "My First Api",
                TermsOfService = new Uri("https://www.google.com"),
                Contact = new OpenApiContact
                {
                    Name = "Abdullah",
                    Email = "abdallaebrahim51@gmail.com",
                    Url = new Uri("https://www.google.com"),
                },
                License = new OpenApiLicense
                {
                    Name = "My License",
                    Url = new Uri("https://www.google.com"),
                }
            });
            //edit swagger document appears on the run secreen

            options.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Enter JWT key" // appears for user that tests end points
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
                        },
                        Name = "Bearer",
                        In = ParameterLocation.Header
                    },
                    new List<string>()
                }
            });
        }

    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(
    c => c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()
    );

app.UseAuthorization();


app.MapControllers();

app.Run();
