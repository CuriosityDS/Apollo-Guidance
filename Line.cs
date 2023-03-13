using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo_Guidance
{
    class Line
    {
        protected Tochka tochkaFirst = new Tochka();
        protected Tochka tochkaSecond = new Tochka();
        protected double x, y;
        public Line()
        {
            x = 0;
            y = 0;
            this.tochkaFirst = new Tochka(x, y);
            this.tochkaSecond = new Tochka(x, y);
        }

        public Line(Tochka toch1, Tochka toch2)
        {
            this.tochkaFirst = toch1;
            this.tochkaSecond = toch2;
        }
        public Tochka TochkaFirst
        {
            get { return tochkaFirst; }
            set { tochkaFirst = value; }
        }

        public Tochka TochkaSecond
        {
            get { return tochkaSecond; }
            set { tochkaSecond = value; }
        }
        public override string ToString()
        {
            string PatternWrite = $"Линия: {tochkaFirst.ToString()}и{tochkaSecond.ToString()}";
            return PatternWrite;
        }

        public override bool Equals(object line)
        {
            if (line == null) return false;
            Line _line = (Line)line;
            if (_line.tochkaFirst == tochkaFirst && _line.tochkaSecond == tochkaSecond) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Line lin1, Line lin2)
        {
            return lin1.Equals(lin2);
        }
        public static bool operator !=(Line lin1, Line lin2)
        {
            return !(lin1.Equals(lin2));
        }

        public static Line operator +(Line lin1, Line lin2)
        {
            return new Line(lin1.tochkaFirst + lin2.tochkaFirst, lin1.tochkaSecond = lin2.tochkaSecond);
        }
    }
}
