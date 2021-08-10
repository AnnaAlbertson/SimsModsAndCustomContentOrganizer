using SMACCO.Models.GameModels;
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
            var model = new GameListItem[0];
            return View(model);
        }

        // Get: Game/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}