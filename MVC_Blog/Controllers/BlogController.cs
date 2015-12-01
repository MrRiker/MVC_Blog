﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using REPOBlog;

namespace MVC_Blog.Controllers
{
    public class BlogController : Controller
    {
        PostFac postFac = new PostFac();
        // GET: Blog
        public ActionResult Index()
        {
            
            return View(postFac.GetIndexData());
        }
    }
}