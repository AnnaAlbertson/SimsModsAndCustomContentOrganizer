using Microsoft.AspNet.Identity;
using SMACCO.Models.GameModels;
using SMACCO.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMACCO.Controllers.CustomDataControllers
{
    public class GameController : Controller
    {
        // GET: Game/Index
        public ActionResult Index()
        {
            var userID = Guid.Parse(User.Identity.GetUserId());
            var service = new GameService(userID);
            var model = new GameListItem[0];
            return View(model);
        }

        // Get: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GameCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}