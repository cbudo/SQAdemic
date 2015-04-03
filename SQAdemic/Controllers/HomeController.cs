using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQAdemic.Models;

namespace SQAdemic.Controllers
{
    public class HomeController : Controller
    {
        GameBoardModels board;
       public ActionResult Index()
        {

            board = new GameBoardModels();
            Session["board"] = board;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult playerDraw()
        {
            JsonResult jsonData = new JsonResult();
            jsonData = Json(((GameBoardModels)Session["board"]).drawCard());
            return jsonData;
        }
    }
}