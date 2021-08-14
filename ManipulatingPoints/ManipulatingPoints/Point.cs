using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingPoints
{
    class Point{
        //Encapsulated atributtes of the class
        private float x, y;
        private static uint NumberOfPoints = 0;
        //Public constructors

        //The default constructor initialize the point in the origin (0,0)
        public Point(){
            x=y=0;
            if (NumberOfPoints < uint.MaxValue) NumberOfPoints++;
            else throw new OverflowException();
        }
        //This constructor have the coordenade y like a optional parameter
        //If you dont set a y value, the value is cero
        public Point(float x,float y=0){
            this.x=x;
            this.y=y;
            if (NumberOfPoints < uint.MaxValue) NumberOfPoints++;
            else throw new OverflowException();
        }
        //Public Methods
        //Guetters
        public float getX() => x;
        public float getY() => y;
        public static uint getNumberOfPoints() => NumberOfPoints;
        //Setters
        public void setX(float _x){
            this.x = _x;
        }
        public void setY(float _y){
            this.y = _y;
        }
        public void setPoint(float _x, float _y){
            this.x = _x;
            this.y = _y;
        }
        //Other Methods
        //Methods for increment the coordenades
        public void incrementX(float _inc){
            this.x += _inc;
        }
        public void incrementY(float _inc){
            this.y += _inc;
        }
        public void incrementXY(float _incx,float _incy){
            this.x+=_incx;
            this.y+=_incy;
        }
        //Methods for decrement the coordenades
        public void decrementX(float _inc)
        {
            this.x -= _inc;
        }
        public void decrementY(float _inc)
        {
            this.y -= _inc;
        }
        public void decrementXY(float _incx, float _incy)
        {
            this.x -= _incx;
            this.y -= _incy;
        }
        //Method to calculate a distance to other point
        public double distanceTo(Point _p)
        {
            float distX = this.x - _p.x;
            float distY = this.y - _p.y;
            double dist = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));
            return dist;
        }
    }
}
