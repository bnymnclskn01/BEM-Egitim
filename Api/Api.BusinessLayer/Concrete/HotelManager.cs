using Api.BusinessLayer.Abstract;
using Api.DataAccessLayer.Abstract;
using Api.DataAccessLayer.Concrete;
using Api.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BusinessLayer.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager()
        {
            _hotelRepository= new HotelRepository();
        }

        public Hotel CreateHotel(Hotel hotel)
        {
           return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int ID)
        {
            _hotelRepository.DeleteHotel(ID);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int ID)
        {
            if (ID > 0)
            {
                return _hotelRepository.GetHotelById(ID);
            }
            throw new Exception("id can not be less than 1");
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
