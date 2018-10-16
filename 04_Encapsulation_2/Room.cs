using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_2
{
    public class Room
    {
        private const double MAX_LENGTH = 30d;
        private const double MIN_LENGTH = 6d;
        private const double MAX_WIDTH = 30d;
        private const double MIN_WIDTH = 6d;
        private const double MIN_HEIGHT = 10d;
        private const double MAX_HEIGHT = 12d;

        private double _length;
        private double _width;
        private double _heigth;

        public Room(){}

        public Room(double l, double w, double h)
        {
            Length = l;
            Width = w;
            Heigth = h;
        }

        public double Length
        {
            get => _length;

           private set
            {
                if (value < MIN_LENGTH || value > MAX_LENGTH)
                    throw new Exception("Please enter a length between 6 and 30.");
                else
                    _length = value;
            }
        }
        public double Width
        {
            get =>_width;
            private set
            {
                if (value < MIN_WIDTH || value > MAX_WIDTH)
                    throw new Exception("Please enter a width between 6 and 30.");
                _width = value;
            }
        }
        public double Heigth
        {
            get => _heigth;
            private set
            {
                if (value < MIN_HEIGHT || value > MAX_HEIGHT)
                    throw new Exception("Please enter a heigth between 10 and 12.");
                _heigth = value;
            }
        }

        public double GetSurfaceAreaOfFloor(double length, double width)
        {
            double surfaceAreaFloor = length * width;
            return surfaceAreaFloor;
        }

        public double GetSurfaceAreaOfWalls()
        {
            return _length * _heigth * 2 + _width * _heigth * 2;
        }

    }
}
