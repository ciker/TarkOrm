﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Data;
using TarkOrm.NET.Extensions;
using TarkOrm.NET.Attributes;
using System.Linq.Expressions;
using System.Configuration;

/*
I'm holding in this file some prototype codes temporaly and I'm going to delete it soon before an official release
*/

namespace TarkOrm.NET
{
    public partial class TarkQueryBuilder
    {
        //TODO: Create an extension proper for SQL Server
        //public bool EnableNoLock { get; set; }

        public virtual CommandBuilder<T> Where<T>(/*Expression<Func<TSource, TProperty>> propertyLambda,*/ object value)
        {
            throw new NotImplementedException();
        }
    }

    public class CommandBuilder<T>
    {
        public IEnumerable<T> Execute()
        {
            return null;
        }
    }
}
