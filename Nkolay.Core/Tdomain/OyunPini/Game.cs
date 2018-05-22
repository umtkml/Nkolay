using System.Collections.Generic;
using Nkolay.Web.Infrastructure.Core;

namespace Nkolay.Web.Api.Core.Tdomain.OyunPini
{
    public class Game : TEntity
    {
        //public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NewField { get; set; }
        public decimal Price { get; set; }

        // İlişkili tablolar bu şekilde de oluşturulabilir
        //public virtual ICollection<Player> Players { get; set; }
    }
}
