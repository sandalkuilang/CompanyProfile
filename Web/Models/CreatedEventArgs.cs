using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Krokot.Web.Models
{
    public class CreatedEventArgs<T> : BaseModelEventArgs<T>
    {
        public CreatedEventArgs(Exception exception)
            : base(exception)
        {

        }
    }
}