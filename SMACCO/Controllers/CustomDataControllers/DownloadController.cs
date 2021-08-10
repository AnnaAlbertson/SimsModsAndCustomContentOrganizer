using SMACCO.Models.DownloadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMACCO.Controllers.CustomDataControllers
{
    [Authorize]
    public class DownloadController : Controller
    {
        // GET: Download/Index
        public ActionResult Index()
        {
            var model = new DownloadListItem[0];
            return View(model);
        }

        // GET: Download/Create
        public ActionResult Create()
        {
            return View();
        }

        // HttpPost validation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DownloadCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}