using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo_Guidance
{
    class Tochka:IXob
    {
        protected double x, y;
        public Tochka()
        {
            x = 0;
            y = 0;
        }
        public Tochka(double x)
        {
            this.x = x;
            y = 0;
        }
        public Tochka(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public override string ToString()
        {
            string PatternWrite = $"\nКоординаты x;y [{x};{y}]\n";
            return PatternWrite;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Tochka tochka = obj as Tochka;
            if (tochka.x == x && tochka.y == y) return true;
            else return false;
        }
        public double CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Tochka a, Tochka b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Tochka a, Tochka b)
        {
            return !(a.Equals(b));
        }

        public static Tochka operator +(Tochka a, Tochka b)
        {
            return new Tochka(a.x + b.x, a.y + b.y);
        }
    }
}
