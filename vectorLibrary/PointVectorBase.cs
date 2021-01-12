using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorLibrary
{
    public abstract class PointVectorBase
    {/// <summary>
    /// Eigenschaften
    /// </summary>
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double Tolerance { get; set; } = 1E-6;
        /// <summary>
        /// Konstruktor
        /// </summary>
        protected PointVectorBase() { }
        protected PointVectorBase(double x, double y, double z = 0)
        {
            this.x = x; this.y = y; this.z = z;
        }
        protected PointVectorBase(PointVectorBase source)
        {

        }
        /// <summary>
        /// Methoden
        /// </summary>
        /// <param name="pvb"></param>
        /// <returns></returns>
        protected double CalculateDistanceTo(PointVectorBase pvb)
        {
            return Math.Sqrt(Math.Pow(pvb.x - this.x, 2) + Math.Pow(pvb.y - this.y, 2) + Math.Pow(pvb.z - this.z, 2));
        }
        protected void CalculateSum(params PointVectorBase[] pvbs)
        {
            PointVectorBase sum = new Test();
            foreach (PointVectorBase item in pvbs)
            {
                sum.x += item.x;
                sum.y += item.y;
                sum.z += item.z;
            }
            Console.WriteLine($"Die Summe ist: (x={sum.x};x={sum.y};x={sum.z})");
        }
        protected void CalculatePoduct(double factor)
        {
            PointVectorBase product = new Test();
            product.x = this.x * factor;
            product.y = this.y * factor;
            product.z = this.z * factor;
            Console.WriteLine($"Das Produkt von factor {factor} ergibt: ({product.x},{product.y},{ product.z})");
        }
        /// <summary>
        /// Besondere Methoden
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return $" x={Math.Round(this.x, 2)}, y={Math.Round(this.y, 2)}; z={Math.Round(this.z, 2)} ";
        }
        /// <summary>
        /// Ob objekte gleich sind (Algorithmus steht in Aufgabestellung)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            PointVectorBase objet = new Test();
            bool egal = false;
            PointVectorBase obj1 = this;
            if (obj != null || obj1 != null)
            {

                if (obj.GetType() == obj1.GetType())
                {
                    objet = (PointVectorBase)obj;
                    if (objet.x == obj1.x && objet.y == obj1.y && objet.z == obj1.z)
                    {
                        egal = true;
                    }
                }
            }
            return egal;
        }
        /// <summary>
        /// um einen Hashwert zu erzeugen
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {

            return (int)this.x ^ (int)this.y ^ (int)this.z;
        }
    }
}
