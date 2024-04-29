using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCapAPeus.models
{
    internal class Client(int id, string name, string surnames, string phone)
    {
        private int id = id;

        private string name = name;

        private string surnames = surnames;

        private string phone = phone;
    }
}
