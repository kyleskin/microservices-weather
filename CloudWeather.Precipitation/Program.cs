using CloudWeather.Precipitation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();

app.MapGroup("/")
    .MapPrecipitationApi()
    .WithTags("Precipitation Endpoints");

// Configure the HTTP request pipeline.
app.Run();
