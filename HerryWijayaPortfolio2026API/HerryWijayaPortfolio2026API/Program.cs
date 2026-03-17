using HerryWijayaPortfolio2026API.Data;
using HerryWijayaPortfolio2026API.Project1LandingPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

//var builder = WebApplication.CreateBuilder(args);
var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    // This tells the app that the static files (index.html) 
    // are in the same folder as the DLLs, not a subfolder.
    WebRootPath = "."
});
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Enter: Bearer {your JWT token}"
    });

    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
//builder.Services.AddAuthentication("Bearer")    .AddJwtBearer();
builder.Services.AddAuthentication("Bearer")
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],

        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])
        )
    };
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("HerryWijayaPortfolio2026",
        policy =>
        {
            policy
            .WithOrigins("http://herrywijayareact2026.runasp.net")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();

app.UseCors("HerryWijayaPortfolio2026");

app.UseAuthentication();   // validates JWT
app.UseAuthorization();    // checks [Authorize]

app.MapControllers();

app.MapLandingPage()

    .WithName("Project1_LandingPage")
    .WithOpenApi();
    ;
app.MapFallbackToFile("index.html");
app.Run();

//app.MapGet("/api/project1landingpage", () =>
//{
//    return Results.Ok(new { message = "API working" });
//})
//.AllowAnyOrigin()


//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();


//.WithName("Project1_LandingPage");
//.WithOpenApi();

//https://localhost:7182