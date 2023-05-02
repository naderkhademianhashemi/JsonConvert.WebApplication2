using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newton = Newtonsoft.Json;

namespace JsonConvert.WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var json = "[\"philcollins\",\"Ih8PeterG\"]";
       
            var searchFilters = json;
            var output = Newton.JsonConvert.DeserializeObject<string[]>(searchFilters);
            var lst = output.ToList();
            return View();
        }

        public ActionResult About()
        {
            var json = "[{ \"firstName\":\"John\", \"lastName\":\"Doe\"},]";
            var searchFilters = json;
            var output = Newton.JsonConvert.DeserializeObject<KeyValuePair<string, string>[]>(searchFilters);
            var lst = output.ToList();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}