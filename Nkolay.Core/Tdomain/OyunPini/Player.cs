using System.Collections.Generic;
using Nkolay.Web.Infrastructure.Core;

namespace Nkolay.Web.Api.Core.Tdomain.OyunPini
{
    public class Player : TEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AccountBalance { get; set; }

        // İlişkili tablolar bu şekilde de oluşturulabilir
        //public virtual ICollection<Game> Games { get; set; }
    }
}
