using System;
using System.Collections.Generic;
using System.Text;

namespace _6_7_Praktika_4._1
{
    public class Hotel
    {
        public string HotelName { get; set; }

        private Room[] rooms = new Room[0];
        public Hotel(string hotelName)
        {
            HotelName = hotelName;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
        }
        public Room[] GetRooms()
        {
            return rooms;
        }

        public void MakeReservation(int roomId)
        {
            foreach (var item in rooms)
            {
                if (roomId == item.ID)
                {
                    if (item.IsAvaible==false)
                    {
                        Console.WriteLine("Room is full");
                    }
                    else
                    {
                        Console.WriteLine(item.IsAvaible=false);
                    }
                }
            }
        }


    }
}
