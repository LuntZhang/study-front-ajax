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
            context.Response.ContentType = "application/xml";
            string userName, content;
            userName = context.Request.QueryString["userName"];
            content = context.Request.QueryString["content"];

            // 输出xml
            context.Response.Write("<?xml version='1.0' encoding='utf-8' ?>");
            context.Response.Write("<users>");
            context.Response.Write("<user username='" + userName + "'>");
            context.Response.Write("<cotent>" + content + "</cotent>");
            context.Response.Write("</user>");
            context.Response.Write("</users>");
            context.Response.End();
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