using Api.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BusinessLayer.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelById(int ID);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int ID);
    }
}
