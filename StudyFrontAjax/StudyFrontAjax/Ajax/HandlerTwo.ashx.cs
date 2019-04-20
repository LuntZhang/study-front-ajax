using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFrontAjax.Ajax
{
    /// <summary>
    /// HandlerTwo 的摘要说明
    /// </summary>
    public class HandlerTwo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if(context.Request["id"] !=null && !string.IsNullOrEmpty(context.Request["id"].ToString()))
            {
                context.Response.Write(GetData(context.Request["id"].ToString()));
            }
        }

        private string GetData(string id)
        {
            string str = string.Empty;
            switch (id)
            {
                case "1":
                    str = "case 1";
                    break;
                case "2":
                    str = "case 2";
                    break;
                case "3":
                    str = "case 3";
                    break;
            }
            return str;
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