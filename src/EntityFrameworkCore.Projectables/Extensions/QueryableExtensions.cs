﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Projectables.Services;

namespace EntityFrameworkCore.Projectables.Extensions
{
    public static class QueryableExtensions
    {
        [Obsolete("Use ExpandProjectables instead")]
        public static IQueryable<TModel> ExpandQuaryables<TModel>(this IQueryable<TModel> query)
            => ExpandProjectables(query);

        public static IQueryable<TModel> ExpandProjectables<TModel>(this IQueryable<TModel> query)
            => query.Provider.CreateQuery<TModel>(query.Expression.ExpandProjectables());
    }
}
