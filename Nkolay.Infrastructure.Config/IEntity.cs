using System;

namespace Nkolay.Web.Infrastructure.Core
{
    public interface IEntity
    {
        int Id { get; set; }
        int Durum { get; set; }
        DateTime AddDate { get; set; }
        DateTime LastUpDate { get; set; }
    }
}