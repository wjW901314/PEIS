using HK.PEIS.DTO;
using HK.PEIS.WEB.IService;
using HK.PEIS.WebBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HK.PEIS.UI.Web.Controllers
{
    public class HomeController : BaseController
    {
        [Import]
        private IPowerManager PowerManager { set; get; }

        public HomeController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public JsonResult GetFirstPassReportList(int rows, int page)
        {
            //var lstUsers = new List<DTO_TB_USERS>();
            //for (var i = 0; i < 100; i++)
            //{
            //    var oUser = new DTO_TB_USERS();

            //    oUser.USER_NAME = "aaa" + i;
            //    oUser.USER_PASSWORD = "mamimamihong" + i;
            //    oUser.FULLNAME = "fullname" + i;
            //    lstUsers.Add(oUser);
            //}

            var lstUsers = PowerManager.GetUsers();


            var oRes = Json(new
            {
                total = Convert.ToInt32(Math.Ceiling(lstUsers.Count / (double)rows)),
                page = page,
                records = lstUsers.Count,
                rows = lstUsers.Skip(rows * page - rows).Take(rows).ToArray()
            }, JsonRequestBehavior.AllowGet);
            return oRes;

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
    }
}