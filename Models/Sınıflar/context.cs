using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OgrenciDenemeCodeFirst.Models.Sınıflar
{
    public class context:DbContext
    {

        public DbSet<Ogrenciler> Ogrencilers {get; set;}
    }
}