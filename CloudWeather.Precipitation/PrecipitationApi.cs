using Microsoft.AspNetCore.Mvc;

namespace CloudWeather.Precipitation;

public static class PrecipitationApi
{
    public static RouteGroupBuilder MapPrecipitationApi(this RouteGroupBuilder group)
    {
        group.MapGet("/observation/{zip}", (string zip, [FromQuery] int? days) =>
        {
            return Results.Ok(zip);
        });

        return group;
    }

    public static IResult Get(string zip)
    {
        return TypedResults.Ok(zip);
    }
}
