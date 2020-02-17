using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    class User
    {
        private static List<string> users = new List<string>();

        public void Add(string username)
        {
            users.Add(username);
        }
        public int GetUsersCount()
        {
            return users.Count;
        }

    }
}
