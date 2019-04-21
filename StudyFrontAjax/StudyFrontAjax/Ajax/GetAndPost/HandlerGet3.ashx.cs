﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFrontAjax.Ajax.GetAndPost
{
    /// <summary>
    /// HandlerGet3 的摘要说明
    /// </summary>
    public class HandlerGet3 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string userName, content;
            userName = context.Request.QueryString["userName"];
            content = context.Request.QueryString["content"];

            PingLun pl = new PingLun { Content = content, UserName = userName, Remark = "无"  };
            // 序列化成Json格式
            string strJson = Newtonsoft.Json.JsonConvert.SerializeObject(pl);
            context.Response.Write(strJson);
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