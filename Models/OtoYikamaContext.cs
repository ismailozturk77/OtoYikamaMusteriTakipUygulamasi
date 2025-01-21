using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OtoYikamaMusteriTakibi.Models
{
    public class OtoYikamaContext : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }

        public OtoYikamaContext() : base("name=OtoYikamaVeritabani")
        {
        }
    }
}
