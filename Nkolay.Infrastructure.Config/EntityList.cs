using System.Collections.Generic;
using System.Linq;

namespace Nkolay.Web.Infrastructure.Core
{
    public static class EntityList
    {
        public static List<TEntity> ToEntityList<TEntity>(this IQueryable queryable)
        {
            //queryable.ToList();
            return new List<TEntity>((IEnumerable<TEntity>)queryable);//
        }

    }
}