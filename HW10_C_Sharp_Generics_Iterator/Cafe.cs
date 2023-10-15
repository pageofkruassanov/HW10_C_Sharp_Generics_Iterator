using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_C_Sharp_Generics_Iterator
{
    internal class Cafe : IEnumerable<Worker>
    {
        // some fields about cafe
        Worker[] _workers;

        public Cafe(Worker[] workers)
        {
            _workers = workers;
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            foreach (Worker worker in _workers)
            {
                yield return worker;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
