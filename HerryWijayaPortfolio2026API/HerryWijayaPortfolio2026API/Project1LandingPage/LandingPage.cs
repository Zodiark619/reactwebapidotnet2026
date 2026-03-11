namespace HerryWijayaPortfolio2026API.Project1LandingPage
{

    public static class LandingPage
    {
        public static RouteHandlerBuilder MapLandingPage(this IEndpointRouteBuilder app)
        {
            return app.MapGet("/", () =>
              {

                  return new
                  {

                      name = "Herry Wijaya",
                      heroimage="foto.jpg",

                      position1 = "C# / .NET Developer",
                      position2 = "Junior .NET Software Developer using C# and React",
                      description = "Programmer with 1 year of job experience with bachelor degree of Computer Science. I'm familiar with .NET, C#, React, and SQL.Looking for an opportunity to work and upgrade, as well as being involved in an organization that believes in gaining a competitive edge and giving back to the community.",
                      
                      address = "Bogor",
                      phone = "0895632067037",
                      email = "herrywijaya.33@gmail.com",
                      //

                      github = "https://www.github.com/Zodiark619",
                      linkedin = "https://www.linkedin.com/in/herry-wijaya-78b7a5216/",
                      youtube = "https://www.youtube.com/@herryxz8997",

                      skills = new[]{
                        new { name = "C#", value = "80" },
                        new { name = "Javascript", value = "40" },
                        new { name = ".NET", value = "70" },
                        new { name = "React", value = "40" },
                        new { name = "PostgreSQL", value = "80" },
                        },
                      services = new[]
                      {
                          new{title="Full Stack Web Development",description="Develop web functionality using SQL database, then process the API endpoints in backend using .NET, and serve it in frontend using React SPA."},
                          new{title="Back End Web Development",description="Develop web functionality using Entityframework datacontext for backend purpose, such as Identity for authentication, WebAPI for building API, and MVC for building websites."},
                        
                      },
                      resume ="/HerryWijayaResume.pdf",
                      portfolio = new[]
                      {
                          new{title="Personal e-commerce project using Stripe payment gateway with SQLite database and CRUD",previewimage="portfolio1.png",url="https://github.com/Zodiark619/StripePortfolio" },

                          new{title="Personal project using Blazor with MudBlazor nuget package.",previewimage="portfolio2.png",url="https://github.com/Zodiark619/BlazorHerryWijaya" },
                          new{title="CRUD Personal project using MVC with Identity for login and logout, output data generated from razor model binding.",previewimage="portfolio3.png",url="https://github.com/Zodiark619/Witcher3IngredientsMVC" },
                          new{title="CRUD Personal project using MVC with Identity for login and logout, output data generated from AJAX and REST API endpoint.",previewimage="portfolio4.png",url="https://github.com/Zodiark619/WuchangFallenFeatherChecklist" },
                          
                      }

                  };
              });
        }
    }
    // return Results.Ok("Photos list");
}
