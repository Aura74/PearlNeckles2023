using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlNeckles2023
{
    public interface INecklace
    {
        //public IPearl this[int index] { get; set; }
        public decimal Price { get; }

        int Count();
        int Count(PearlType type);
        void Sort();
        //public int IndexOf(IPearl pearl);
    }
}
