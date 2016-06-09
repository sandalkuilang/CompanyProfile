using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Krokot.Web.Models.Home
{
    public class Content
    {
        public int Id { get; set; }
        public string ContentSection { get; set; }
        public string ContentTitle { get; set; }
        public string ContentText { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; } 
    }
}