namespace HerryWijayaPortfolio2026API.Project2JwtAuthentication
{
    public static class JwtAuthentication
    {
        public static RouteHandlerBuilder MapJwtAuthentication(this IEndpointRouteBuilder app)
        {
            return app.MapGet("/api/project2jwtauthentication", () =>
            {
                return new { };
            });


        }
    }
}
