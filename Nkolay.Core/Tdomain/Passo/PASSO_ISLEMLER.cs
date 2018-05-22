using System;
using Nkolay.Web.Infrastructure.Core;

namespace Nkolay.Web.Api.Core.Tdomain.Passo
{
    public class PASSO_ISLEMLER : DEntity
    {
        public int Bayi_Id { get; set; }
        public decimal Bayi_Limit { get; set; }
        public decimal Bayi_Kredi_Limit { get; set; }
        public bool Tarih_Durum { get; set; }
        public DateTime Limit_GecerlilikTarihi { get; set; }
        public string Kod { get; set; }
        public int Para_Birim_Id { get; set; }
        public int Row_Ver { get; set; }
        public bool Kilit { get; set; }
        public decimal Limit_Uyari_Ust { get; set; }
        public decimal Limit_Uyari_Alt { get; set; }
    }
}
