using System;

namespace _6_7_Praktika_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel("Diamond");
            Room room1 = new Room("Otaq1",15,2);
            Room room2 = new Room("Otaq2", 150, 5);

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            foreach (var item in hotel.GetRooms())
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in hotel.GetRooms())
            {
                hotel.MakeReservation(5);
            }
        }
    }
}
