using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_C_Sharp_Generics_Iterator
{
    internal class Player : IPlayer
    {
        private string _name;

        private string _description;

        public Player(string name, string description)
        {
            _name = name;
            _description = description;
        }
        
        public string ShowInfo()
        {
            return ("Name: " + _name + '\n' + "Description: " + _description);
        }
    }
}
