using Demo__NET_CYBER_ASP.Data;
using Microsoft.AspNetCore.Mvc;

namespace Demo__NET_CYBER_ASP.Controllers
{
    public class GameController : Controller
    {

        private readonly GameData _data;

        public GameController(GameData data)
        {
            _data = data;
        }

        public IActionResult Index()
        {

            ViewBag.Titre = "Game";
            return View(_data.Get());
        }
    }
}
