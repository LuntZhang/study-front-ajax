using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryDemos.Plugin.Form
{
    /// <summary>
    /// Handler2 的摘要说明
    /// </summary>
    public class Handler2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string name = context.Request.Form["name"];
            string address = context.Request.Form["address"];
            string comment = context.Request.Form["comment"];

            string strHtml = "<h1>" + name + ";" + address + ";" + comment + "</h1>";
            context.Response.Write(strHtml);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}