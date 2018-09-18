using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplicationWCF
{
    [ServiceContract]
    interface IHotel
    {
        [OperationContract]
        List<Hotel> GetAllHotels();

        [OperationContract]
        Hotel GetHotelById(int id);
    }
}
