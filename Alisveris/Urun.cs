﻿using Alisveris.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris
{
    internal class Urun : IKisi
    {
        public string Turu { get; set; }
        public int  Fiyat { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
