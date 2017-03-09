using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
         * Adding a View
         */
        public ActionResult Index()
        {
            return View();
        }
        /*
         * Passing Data from the Controller to the View
         * /HelloWorld/Welcome?name=JaneConan&numtimes=6
         */
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        /*
         * Adding a Controller
         */

        // 
        // GET: /HelloWorld/ 

        /*
         public string Index()
        {
            return "This is my <b>default</b> action...";
        }
         */

        // 控制器/反应名/属性名
        //[Controller]/[ActionName]/[Parameters]

        // GET: /HelloWorld/Welcome/ 

        /**
         * 
         * 第一种方法：name&numtimes
         * 格式：Welcome?name=XXX&numtimes=6
         * URL：http://localhost:xxxx/HelloWorld/Welcome?name=JaneConan&numtimes=6)
         */

        /* public string Welcome(string name, int numTimes = 1)
         {
          //return "This is the Welcome action method...";
             // return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);

         }
         */
        /**
         * 第二种方法：name&ID
         * 格式：/Welcome/3?name=XXX
         * URL：http://localhost:xxx/HelloWorld/Welcome/6?name=JaneConan
         * 
         */
       /* 
        * public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
        */
        /**
         * 第三种方法：在ReuteConfig.cs中增加
         * routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{id}"
            );
         * URL：可输入/localhost:XXX/HelloWorld/Welcome/Scott/3
         * 即可传值并访问
         */

    }
}