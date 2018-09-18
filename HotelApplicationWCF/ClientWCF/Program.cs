using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientWCF.ServiceReference;
using HotelApplicationWCF;

namespace ClientWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            HotelClient clientObject = new HotelClient();
            Console.WriteLine("Enter The option you want to perform: 1: GetAllHotels 2: GetHotelById");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        List<Hotel> data = new List<Hotel>(clientObject.GetAllHotels());
                        foreach (var hotel in data)
                        {
                            Console.WriteLine("Hotel id: "+hotel.HotelId);
                            Console.WriteLine("Hotel Name: "+hotel.HotelName);
                            Console.WriteLine("Hotel Address: "+hotel.HotelAddress);
                            Console.WriteLine("Hotel Pin Code: "+hotel.HotelPinCode);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the id which you want to get: ");
                        int id = int.Parse(Console.ReadLine());
                        Hotel hotelObject = clientObject.GetHotelById(id);
                        Console.WriteLine("Hotel id: " + hotelObject.HotelId);
                        Console.WriteLine("Hotel Name: " + hotelObject.HotelName);
                        Console.WriteLine("Hotel Address: " + hotelObject.HotelAddress);
                        Console.WriteLine("Hotel Pin Code: " + hotelObject.HotelPinCode);
                        break;
                    }
            }
          
            
            Console.ReadKey();
        }
    }
}
