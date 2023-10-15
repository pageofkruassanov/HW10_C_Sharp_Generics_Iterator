using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_C_Sharp_Generics_Iterator
{
    internal class Tuna : ISeaCreature
    {
        private string _name;

        public Tuna(string name)
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

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("Fish name: ");
        //    sb.Append(_name);
        //    sb.Append("\nDescription of the fish: ");
        //    sb.Append(_description);
        //    return sb.ToString();
        //}

    }
}
