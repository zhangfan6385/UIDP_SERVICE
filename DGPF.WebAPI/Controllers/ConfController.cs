﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DGPF.BIZModule;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DGPF.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class ConfController : Controller
    {
        ConfModule mm = new ConfModule();
        // GET api/values
        [HttpGet("fetchConfigList")]
        public IActionResult fetchConfigList(string limit, string page, string CONF_NAME)
        {

            Dictionary<string, object> d = new Dictionary<string, object>();
            d["limit"] = limit;
            d["page"] = page;
            d["CONF_NAME"] = CONF_NAME;
            return Json(mm.fetchConfigList(d));
        }

        [HttpPost("createConfigArticle")]
        public IActionResult createConfigArticle([FromBody]JObject value)
        {

            Dictionary<string, object> d = value.ToObject<Dictionary<string, object>>();

            Dictionary<string, object> r = new Dictionary<string, object>();

          
            try
            {
                string b = mm.createConfigArticle(d);
                if (b == "")
                {
                    r["message"] = "成功";

                    r["code"] = 2000;
                }
                else
                {
                    r["code"] = -1;
                    r["message"] = b;
                }
               
            }
            catch (Exception e)
            {
                r["code"] = -1;
                r["message"] = e.Message;
            }
            return Json(r);


        }

        [HttpPost("updateConfigData")]
        public IActionResult updateConfigData([FromBody]JObject value)
        {

            Dictionary<string, object> d = value.ToObject<Dictionary<string, object>>();

            Dictionary<string, object> r = new Dictionary<string, object>();


            try
            {
                string b = mm.updateConfigData(d);
                if (b == "")
                {
                    r["message"] = "成功";

                    r["code"] = 2000;
                }
                else
                {
                    r["code"] = -1;
                    r["message"] = b;
                }

            }
            catch (Exception e)
            {
                r["code"] = -1;
                r["message"] = e.Message;
            }
            return Json(r);


        }

        [HttpPost("updateConfigArticle")]
        public IActionResult updateConfigArticle([FromBody]JObject value)
        {

            Dictionary<string, object> d = value.ToObject<Dictionary<string, object>>();

            Dictionary<string, object> r = new Dictionary<string, object>();


            try
            {
                string b = mm.updateConfigArticle(d);
                if (b == "")
                {
                    r["message"] = "成功";

                    r["code"] = 2000;
                }
                else
                {
                    r["code"] = -1;
                    r["message"] = b;
                }

            }
            catch (Exception e)
            {
                r["code"] = -1;
                r["message"] = e.Message;
            }
            return Json(r);


        }

        
    }
}