using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorLibrary
{
    class Test: PointVectorBase
    {
        public Test() { }
        public Test(double x, double y, double z = 0)
        {
            this.x = x; this.y = y; this.z = z;
        }
        public Test(PointVectorBase source)
        {

        }

        public static void TestPointVectorBase()
        {
            // Objekte werden erstellt
            Test X = new Test();
            X.x = 10.789;
            X.z = 6.138;
            Test Y = new Test(1, 6, 8);
            Test Z = new Test(X);
            Console.WriteLine($"Die Distanz von Y to Z ist: {Y.CalculateDistanceTo(Z)}");
            Z.CalculateSum(Y, X);
            Y.CalculatePoduct(5);
            Console.WriteLine(X.ToString());
            Console.WriteLine($"Equal bei \"PointVectorBase\" ist: {Y.Equals(X)}");
            Console.WriteLine($"Der Hash-Code bei PointVectorBase ist:  {Y.GetHashCode()}");



        }
    }
}
