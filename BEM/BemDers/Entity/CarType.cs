using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BemDers.Entity
{
    public class CarType :Araba
    {
        private string type;
        public string CType
        {
            get { return type; }
            set { type = value; }
        }
        private string numberDoor;
        public string NumberDoor
        {
            get { return numberDoor; }
            set { numberDoor = value; }
        }
        private string fuelType;
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
    }
}
