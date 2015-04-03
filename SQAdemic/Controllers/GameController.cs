using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQAdemic.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult playerDraw()
        {
            JsonResult jsonData = new JsonResult();

            return jsonData;
        }
    }
}