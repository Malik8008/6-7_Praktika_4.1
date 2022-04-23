using System;
using System.Collections.Generic;
using System.Text;

namespace _6_7_Praktika_4._1
{
    public class Room
    {
        public int ID { get; }
        public static int Count = 0;
        public string Name { get; set; }
        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        private byte _personcapacity;
        public byte PersonCapacity
        {
            get
            {
                return _personcapacity;
            }
            set
            {
                if (value>0)
                {
                    _personcapacity = value;
                }
            }
        }
        public bool IsAvaible=true;

        public Room(string name, int price,byte personCapacity)
        {
            Count++;
            ID = Count;
            Name = name;
            Price = price;  
            PersonCapacity = personCapacity;           
        }

        public string ShowInfo()
        {
            return $"ID:{ID} | Name:{Name} | Price:{Price} | PersonCapacity:{PersonCapacity}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
