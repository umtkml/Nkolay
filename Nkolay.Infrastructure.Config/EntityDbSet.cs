using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Nkolay.Web.Infrastructure.Core
{
    public static class EntityDbSet
    {
        public static DbSet<IEntity> ToEntityDbSet(this DbContext context)
        {
            IQueryable queryable = context.Set<BaseEntity>().Where(x => x.Durum == -1);
            return (DbSet<IEntity>)queryable;
        }

    }
}