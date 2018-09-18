using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonWCF
{
    //[DataContract]
    class HotelService : IHotel
    {
       

        public List<Hotel> GetAllHotels()
        {
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/" + "Hotel.json";
            using (StreamReader sr = new StreamReader(path))
            {
                var json = sr.ReadToEnd();
                List<Hotel> items = JsonConvert.DeserializeObject<List<Hotel>>(json);
                return items;
            }
        }

        public Hotel GetHotelById(int id)
        {
            List<Hotel> items;
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/" + "Hotel.json";
            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Hotel>>(json);
                
            }
            foreach (var hotel in items)
            {
                if (hotel.HotelId == id)
                {
                    return hotel;
                }

            }
            return null;
        }
    }
}
