using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Krokot.Web.Models.Home
{
    public class ContentRepository : BaseCommandRespository
    {
        public List<Content> GetContent(dynamic param)
        {
            this.Database.Open();
            List<Content> result = this.Database.Query<Content>("GetContent", param);

            this.Database.Close();
            return result;
        }
    }
}