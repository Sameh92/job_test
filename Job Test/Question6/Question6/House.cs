using System;
using System.Collections.Generic;
using System.Text;

namespace Question6
{
    class House
    {
        private List<string> house_room = new List<string>();

        public House(List<string> hous_room_list)
        {
            this.house_room = hous_room_list;
        }

        public string Describe()
        {
            string room = "";
            string allRoom;
            foreach (string listRoom in house_room)
            {
                room = room + " , " + listRoom;
            }
            allRoom = room.Substring(3);
            return allRoom;
        }
    }
}
