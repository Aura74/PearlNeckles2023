using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlNeckles2023
{
    public enum PearlColor { Black, White, Pink }
    public enum PearlShape { Round, DropShaped }
    public enum PearlType { FreshWater, SaltWater }
    public interface IPearl : IEquatable<IPearl>, IComparable<IPearl>
    {
        public int Size { get; set; }
        public PearlColor Color { get; set; }
        public PearlShape Shape { get; set; }
        public PearlType Type { get; set; }
        public decimal Price { get; }
    }
}
