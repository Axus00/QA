using Api.Infrastructure.Data;
using Api.Models;
using Api.Services.Interface;
using Api.Services.Repository;
using Api.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

const string MyCors = "CorsPolicy";

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


//service to context
builder.Services.AddDbContext<BaseContext>(options => 
                    options.UseMySql(
                    builder.Configuration.GetConnectionString("DbConnection"),
                    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));


//Cors
builder.Services.AddCors(policy => {
    policy.AddPolicy(MyCors, builder => 
    {
        builder.WithOrigins("http://localhost:5283/")
                .WithHeaders("content-type")
                .WithMethods("GET");
    });
});

//service to Validators
builder.Services.AddScoped<IValidator<User>, UserValidator>();


//service to interface
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

//Controllers Middleware
app.MapControllers();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
