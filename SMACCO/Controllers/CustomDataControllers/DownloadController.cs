using SMACCO.Models.DownloadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMACCO.Controllers.CustomDataControllers
{
    public class DownloadController : Controller
    {
        // GET: Download
        public ActionResult Index()
        {
            var model = new DownloadListItem[0];
            return View(model);
        }
    }
}