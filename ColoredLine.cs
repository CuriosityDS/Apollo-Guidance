using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo_Guidance
{
    class ColoredLine:Line
    {
        protected string color;
        public ColoredLine() : base()
        {
            color = "Dark white";
        }
        public ColoredLine(Tochka tochkaFirst, Tochka tochkaSecond) : base(tochkaFirst, tochkaSecond)
        {
            color = "Blood red";
        }
        public ColoredLine(Tochka tochkaFirst, Tochka tochkaSecond, string color) : base(tochkaFirst, tochkaSecond)
        {
            this.color = color;
        }
        public override string ToString()
        {
            string PatternWrite = $"\nЛиния и color [{color}]{tochkaFirst.ToString()}и{tochkaSecond.ToString()}";
            return PatternWrite;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public override bool Equals(object colorline)
        {
            if (colorline == null) return false;
            ColoredLine _line = (ColoredLine)colorline;
            if (_line.tochkaFirst == tochkaFirst && _line.tochkaSecond == tochkaSecond && _line.color == color) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ColoredLine colorLine1, ColoredLine colorLine2)
        {
            return colorLine1.Equals(colorLine2);
        }

        public static bool operator !=(ColoredLine colorLine1, ColoredLine colorLine2)
        {
            return !(colorLine1.Equals(colorLine2));
        }

        public static ColoredLine operator +(ColoredLine colorLine1, ColoredLine colorLine2)
        {
            return new ColoredLine(colorLine1.tochkaFirst + colorLine2.tochkaFirst, colorLine1.tochkaSecond + colorLine2.tochkaSecond, colorLine1.color = colorLine2.color);
        }
    }

}

