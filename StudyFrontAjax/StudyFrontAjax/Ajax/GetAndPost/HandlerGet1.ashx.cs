using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFrontAjax.Ajax.GetAndPost
{
    /// <summary>
    /// HandlerGet1 的摘要说明
    /// </summary>
    public class HandlerGet1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName, content;
            userName = context.Request.QueryString["userName"];
            content = context.Request.QueryString["content"];
            string strHtml = @"<div><h6>" + userName + "</h6></div><div><p>" + content + "</p></div>";
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