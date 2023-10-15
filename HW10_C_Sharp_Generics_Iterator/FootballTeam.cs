using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW10_C_Sharp_Generics_Iterator
{
    internal class FootballTeam : IEnumerable<IPlayer>
    {
        private string _name;
        private IPlayer[] _players;

        public FootballTeam(IPlayer[] players, string name)
        {
            _players = players;
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
        public IEnumerator<IPlayer> GetEnumerator()
        {
            foreach(IPlayer p in _players)
            {
                yield return p;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
