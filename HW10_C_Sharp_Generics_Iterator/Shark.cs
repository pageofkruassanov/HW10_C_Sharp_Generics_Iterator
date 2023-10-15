using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_C_Sharp_Generics_Iterator
{
    internal class Shark : ISeaCreature
    {
        private string _name;

        public Shark(string name)
        {
            _name = name;
        }

        public string Swim()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The ");
            sb.Append(_name);
            sb.Append(" began to swim");
            return sb.ToString();
        }
    }
}
