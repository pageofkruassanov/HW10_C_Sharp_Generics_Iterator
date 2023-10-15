using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_C_Sharp_Generics_Iterator
{
    internal class Aquarium : IEnumerable<ISeaCreature>
    {
        private ISeaCreature[] _seaCreature;

        public Aquarium(ISeaCreature[] seaCreatures)
        {
            _seaCreature = seaCreatures;
        }

        public IEnumerator<ISeaCreature> GetEnumerator()
        {
            foreach (ISeaCreature creature in _seaCreature)
            {
                yield return creature;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
