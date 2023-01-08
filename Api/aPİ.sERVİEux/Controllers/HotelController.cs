using Api.BusinessLayer.Abstract;
using Api.BusinessLayer.Concrete;
using Api.DataAccessLayer.Abstract;
using Api.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.ServiceUX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private IHotelService _service;
        public HotelController(IHotelService hotelService)
        {
            _service = hotelService;
        }

        [HttpGet]
        public List<Hotel> Get()
        {
            return _service.GetAllHotels();
        }
        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _service.GetHotelById(id);
        }
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return _service.UpdateHotel(hotel);
        }

        [HttpPost]
        public Hotel Post([FromBody] Hotel hotel)
        {
            return _service.CreateHotel(hotel);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            throw new System.NotImplementedException();
        }
    }
}
