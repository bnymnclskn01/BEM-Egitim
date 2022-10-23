using BemDers.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BemDers.Abstract
{
    public abstract class Mobilya
    {
        public string Renk { get; set; }
        abstract public void OzellikYaz();
    }
}
