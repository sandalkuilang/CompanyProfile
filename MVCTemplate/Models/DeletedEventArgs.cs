﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Krokot.Web.Models
{
    public class DeletedEventArgs<T> : BaseModelEventArgs<T>
    {
        public DeletedEventArgs(Exception exception)
            : base(exception)
        {

        }
    }
}