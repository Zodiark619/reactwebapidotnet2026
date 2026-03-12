using HerryWijayaPortfolio2026API.Project1LandingPage;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("HerryWijayaPortfolio2026",
        policy =>
        {
            policy.WithOrigins("https://zodiark619.github.io")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
}); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("HerryWijayaPortfolio2026");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

 
app.MapLandingPage().WithName("Project1_LandingPage")
.WithOpenApi();
app.Run();

 //https://localhost:7182