namespace HerryWijayaPortfolio2026API.Project1LandingPage
{
    
    public static class LandingPage
    {
        public static RouteHandlerBuilder MapLandingPage(this IEndpointRouteBuilder app)
        {
          return  app.MapGet("/", () =>
            {

                return new
                {
                    name="Herry Wijaya",
                    email="herrywijaya065116076@unpak.ac.id",
                    github="github.com/Zodiark619"
                };
               // return Results.Ok("Photos list");
            });
        }
    }
}
