using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplicationWCF
{
    [DataContract]
    class HotelServiceWCF : IHotel
    {
        HotelData dataObject = new HotelData();
        public List<Hotel> GetAllHotels()
        {
            return dataObject.hotelList;
        }

        public Hotel GetHotelById(int id)
        {
            foreach (var hotel in dataObject.hotelList)
            {
                if (hotel.HotelId==id)
                {
                    return hotel;
                }
              
            }
            return null;
        }
    }
}
