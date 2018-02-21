using System.Web.Mvc;

namespace Presentation
{
    public sealed class ArtistController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
