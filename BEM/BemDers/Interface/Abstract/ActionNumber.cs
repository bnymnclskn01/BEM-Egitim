using BemDers.Interface.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BemDers.Interface.Abstract
{
    public class ActionNumber : IAction
    {
        private string actionCode;
        private string Date;
        private double Amount;
        public ActionNumber()
        {
            actionCode = "";
            Date = "";
            Amount = 0.0;
        }

        public ActionNumber(string c, string d, double a)
        {
            actionCode = c;
            Date = d;
            Amount = a;
        }


        public void ActionView()
        {
            Console.WriteLine("İşlem No : {0}", actionCode);
            Console.WriteLine("Tarih : {0}", Date);
            Console.WriteLine("Tutar : {0}", AmountGet());
        }

        public double AmountGet()
        {
            return Amount;
        }
    }
}
