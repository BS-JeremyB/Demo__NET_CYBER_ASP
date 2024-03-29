﻿using Demo__NET_CYBER_ASP.Data;
using Demo__NET_CYBER_ASP.Models;
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

        public IActionResult Detail(int id)
        {
            Game? game = _data.GetById(id);

            if (game == null)
            {
                return RedirectToAction("Index");
            }

            return View(game);
        }

        public IActionResult Edit(int id)
        {
            Game? game = _data.GetById(id);

            if (game == null)
            {
                return RedirectToAction("Index");
            }

            return View(game);
        }


        [HttpPost]
        public IActionResult Edit(Game game)
        {
            _data.Edit(game);
            return RedirectToAction("Index");
        }


        // Create action

        public IActionResult Create()
        {
            Game game = new Game();
            return View(game);

        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            _data.Add(game);
            return RedirectToAction("Detail", new { game.Id });
        }

        // Delete action

        public IActionResult Delete(int id)
        {
            _data.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
