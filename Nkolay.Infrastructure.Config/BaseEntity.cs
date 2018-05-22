using System;

namespace Nkolay.Web.Infrastructure.Core
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public int Durum { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime LastUpDate{ get; set; }
    }
}
