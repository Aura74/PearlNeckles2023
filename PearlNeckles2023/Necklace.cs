using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace PearlNeckles2023
{
    public class Necklace : INecklace, IEnumerable<IPearl>
    {
        private List<IPearl> _stringOfPearls = new List<IPearl>();

        public IEnumerator<IPearl> GetEnumerator()
        {
            foreach (var item in _stringOfPearls)
            {
                yield return item;
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator(); // needed as IEnumerable<> implmenents IEnumerable.
                                                                    // keep private

        public IPearl this[int idx] => _stringOfPearls[idx];
        public decimal Price
        {
            get
            {
                //_stringOfPearls.Sum(x => x.Price);
                var price = 0M;
                foreach (var p in _stringOfPearls)
                {
                    price += p.Price;
                }
                return price;
            }
        }

        public int Count() => _stringOfPearls.Count;

        public int Count(PearlType type)
        {
            //_stringOfPearls.Where(o => o.Type == type).Count();
            int c = 0;
            foreach (var item in _stringOfPearls)
            {
                if (type == item.Type)
                    c++;
            }
            return c;
        }

        //public int IndexOf(IPearl pearl) => _stringOfPearls.IndexOf(pearl);

        public override string ToString()
        {
            string sRet = $"Necklace has the following pearls:\n";
            foreach (var item in _stringOfPearls)
            {
                sRet += $"{item}\n";
            }
            return sRet;
        }


        public void Sort() => _stringOfPearls.Sort();
        public int IndexOf(IPearl pearl) => _stringOfPearls.IndexOf(pearl);

        public bool HasPearlSize(int size)
        {
            return _stringOfPearls.Find(x => x.Size == size) != null;
        }
        public Necklace FindAllOfSize(int size)
        {
            var n = new Necklace();
            n._stringOfPearls = this._stringOfPearls.FindAll(x => x.Size == size);

            return n;
        }

        #region Class Factory for creating an instance filled with Random data
        internal static class Factory
        {
            internal static Necklace CreateRandomNecklace(int NrOfItems)
            {
                var necklace = new Necklace();
                for (int i = 0; i < NrOfItems; i++)
                {
                    necklace._stringOfPearls.Add(Pearl.Factory.CreateRandomPearl());
                }
                return necklace;
            }
        }
        #endregion

        #region Methods for writing a neclace to disk
        public string Write(string filename)
        {
            string fn = fname(filename);
            using (FileStream fs = File.Create(fn))
            using (TextWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(this);
            }
            return fn;
        }
        static string fname(string name)
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            documentPath = Path.Combine(documentPath, "ADOP", "Examples");
            if (!Directory.Exists(documentPath)) Directory.CreateDirectory(documentPath);
            return Path.Combine(documentPath, name);
        }

        #endregion
    }
}
