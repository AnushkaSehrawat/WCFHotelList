using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplicationWCF
{
    class HotelData
    {
        public List<Hotel> hotelList = new List<Hotel>()
        {
            new Hotel{HotelId=1,HotelName="abc",HotelAddress="xyz",HotelPinCode=123 },
            new Hotel{HotelId=2,HotelName="abc",HotelAddress="xyz",HotelPinCode=123 },
            new Hotel{HotelId=3,HotelName="abc",HotelAddress="xyz",HotelPinCode=123 },
        };
    }
}
