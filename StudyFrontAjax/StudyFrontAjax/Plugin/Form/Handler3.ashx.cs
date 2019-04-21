using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryDemos.Plugin.Form
{
    /// <summary>
    /// Handler3 的摘要说明
    /// </summary>
    public class Handler3 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
          
            string name = context.Request.Form["name"];
            string address = context.Request.Form["address"];
            string comment = context.Request.Form["comment"];
            string strHtml = "{'name':'"+name+"','address':'"+address+"','comment':'"+comment+"'}";
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