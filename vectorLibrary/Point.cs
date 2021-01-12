using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorLibrary
{
    public class Point: PointVectorBase
    {
        public static Point Origin { get; }
        public Vector AsVektor { get; }


        public Point() { }
        public Point(double x, double y, double z = 0)
        {
            this.x = x; this.y = y; this.z = z;
        }
        public Point(Point Source)
        {

        }


        public Point Add(params Vector[] vecs)
        {
            base.CalculateSum(vecs);
            return new Point();
        }
        public double DistanceTo(Point Point2)
        {
            return base.CalculateDistanceTo(Point2);
        }


        public override string ToString()
        {
            return $"(Point) {base.ToString()}";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Operatorüberladung
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Point operator +(Point p1, Vector v1)
        {

            return new Point(p1.x + v1.x, p1.y + v1.y, p1.z + v1.z);
        }
        public static Point operator -(Point p1, Vector v1)
        {

            return new Point(p1.x - v1.x, p1.y - v1.y, p1.z - v1.z);
        }
        public static Point operator *(Point p1, Vector v1)
        {

            return new Point(p1.x * v1.x, p1.y * v1.y, p1.z * v1.z);
        }


        public static bool operator ==(Point p1, Vector v1)// Der "==" Operator muss immer mit dem "!=" 
                                                           //...Operator implementiert werden
        {

            return p1 is Point && v1 is Vector;
        }
        public static bool operator !=(Point p1, Vector v1)
        {
            return !(p1 is Point && v1 is Vector);

        }
    }
}
