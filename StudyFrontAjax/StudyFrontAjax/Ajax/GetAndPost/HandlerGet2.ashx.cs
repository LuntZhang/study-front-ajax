using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFrontAjax.Ajax.GetAndPost
{
    /// <summary>
    /// HandlerGet2 的摘要说明
    /// </summary>
    public class HandlerGet2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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