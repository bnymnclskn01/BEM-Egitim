using Api.DataAccessLayer.Abstract;
using Api.DataAccessLayer.ModelContext;
using Api.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataAccessLayer.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Hotels.Add(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
        }

        public void DeleteHotel(int ID)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                var deleteHotel = GetHotelById(ID);
                hotelDbContext.Hotels.Remove(deleteHotel);
                hotelDbContext.SaveChanges();
            }

        }

        public List<Hotel> GetAllHotels()
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.ToList();
            }
        }

        public Hotel GetHotelById(int ID)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.Find(ID);
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Hotels.Update(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
        }
    }
}
