using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryDemos.Plugin.Form
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string name = context.Request.Form["name"];
            context.Response.Write("后台的"+name);
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