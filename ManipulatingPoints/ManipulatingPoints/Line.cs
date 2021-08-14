using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingPoints
{
    class Line{
        //Encapsulated atributes
        private Point p1, p2;
        //Public Constructors
        public Line(Point _p1,Point _p2){
            p1 = _p1;
            p2 = _p2;
        }
        //Public Methods
        //Guetters
        public Point getP1() => p1;
        public Point getP2() => p2;
        //Setters
        public void SetP1(Point _p1)
        {
            p1 = _p1;
        }
        public void SetP2(Point _p2)
        {
            p2 = _p2;
        }
        public void SetP1P2(Point _p1, Point _p2)
        {
            p1 = _p1;
            p2 = _p2;
        }
    }
}
