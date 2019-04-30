using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppSecurity.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [AllowHtml]
        public string Body { get; set; }
    }
}