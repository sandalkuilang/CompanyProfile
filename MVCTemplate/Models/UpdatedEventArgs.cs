﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Krokot.Web.Models
{
    public class UpdatedEventArgs<T> : BaseModelEventArgs<T>
    {
        public UpdatedEventArgs(Exception exception)
            : base(exception)
        {

        }
    }
}