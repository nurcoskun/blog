using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class YazilarViewModels
    {
        public YazilarViewModels()
        {
            YaziListesi = new List<Yazilar>();
        }
        public List<Yazilar> YaziListesi { get; set; }


    }
}