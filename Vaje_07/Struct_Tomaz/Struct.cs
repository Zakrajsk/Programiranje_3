using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Tomaz
{
    public struct Tocka
    {
        private double _x;
        private double _y;

        public Tocka(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public override string ToString()
        {
            return $"({this._x}, {this._y})";
        }

    }

    public class TockaRaz
    {
        private double _x;
        private double _y;

        public TockaRaz(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public override string ToString()
        {
            return $"({this._x}, {this._y})";
        }

    }


    class Struct
    {
        static void Main(string[] args)
        {
        }
    }
}
