using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OgrenciDenemeCodeFirst.Models.Sınıflar
{
    public class Ogrenciler
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ID { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string OgrenciNot1 { get; set; }
        public string OgrenciNot2 { get; set; }
        public string OgrenciOrtalama { get; set; }

    }
}