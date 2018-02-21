using System.Web.Http;

namespace WebAngularApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "ArtistApiRoute",
               routeTemplate: "api/artist",
               defaults: new { controller = "ArtistApi" }
           );

            config.Routes.MapHttpRoute(
              name: "ArtistCreateApiRoute",
              routeTemplate: "api/artist/add",
              defaults: new { controller = "ArtistApi", action= "CreateArtist" }
          );
        }
    }
}
