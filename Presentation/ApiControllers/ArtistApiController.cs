using ApplicationServices.Interfaces;
using ApplicationServices.Model;
using System.Web.Http;
using UnityBootstrapper;
using Microsoft.Practices.Unity;

namespace Presentation.ApiControllers
{
    public class ArtistApiController : ApiController
    {
        private readonly IArtistService _artistService;
        public ArtistApiController()
        {
            var artistService = AppContainer.Current.Resolve<IArtistService>();
            _artistService = artistService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_artistService.GetArtistsDetails());
        }

        [HttpPost]
        public IHttpActionResult CreateArtist(ArtistDto artist)
        {
            return Ok(_artistService.SaveArtistInfo(artist));
        }
    }
}
