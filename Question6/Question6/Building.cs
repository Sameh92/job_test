using System;
using System.Collections.Generic;
using System.Text;

namespace Question6
{
    class Building
    {
        private List<string> building_room_list = new List<string>();

        public Building AddKitchen()
        {
            this.building_room_list.Add("kitchen");
            return this;
        }
        public Building AddBedroom(string s)
        {
            this.building_room_list.Add(s + " room");
            return this;
        }
        public Building AddBalcony()
        {
            this.building_room_list.Add("balcony");
            return this;
        }
        public House Build()
        {
            return new House(this.building_room_list);
        }
    }
}
