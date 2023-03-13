using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo_Guidance
{
    class Polygon
    {
        protected int Angles = 0;
        protected Line[] Lines = new Line[20];
        private bool flag = true;
        public Polygon()
        {
            Lines[0] = new Line();
            Angles = 1;
        }
        public Polygon(params Line[] lin)
        {
            Array.Copy(lin, Lines, lin.Length);
            Angles = lin.Length;
        }
        public override string ToString()
        {
            string PatternWrite = $"\nКол-во углов:{Angles}\n";
            for (int i = 0; i < Angles; i++)
            {
                PatternWrite += Lines[i];
            }
            return PatternWrite;
        }
        public override bool Equals(object polygon)
        {
            if (polygon == null) return false;
            Polygon _polygon = (Polygon)polygon;
            for (int i = 0; i < Angles; i++)
                {
                    if (this.Lines[i].Equals(_polygon.Lines[i]))
                        flag = false;
                }
            return flag;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Polygon polygonFirst, Polygon polygonSecond)
        {
            return polygonFirst.Equals(polygonSecond);
        }

        public static bool operator !=(Polygon polygonFirst, Polygon polygonSecond)
        {
            return !(polygonFirst.Equals(polygonSecond));
        }
    }
}
