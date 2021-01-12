using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace vectorLibrary
{
    public class Vector:PointVectorBase
    {
        /// <summary>
        /// Eigenschaten
        /// </summary>
        public static Vector XDir { get; }
        public static Vector YDir { get; }
        public static Vector ZDir { get; }
        public double Length { get; set; }
        public Point AsPoint { get; set; }

        /// <summary>
        /// constucteur
        /// </summary>
        public Vector()
        {

        }
        public Vector(double x, double y, double z = 0)
        {
            this.x = x; this.y = y; this.z = z;
        }
        public Vector(Vector Source)
        {

        }

        /// <summary>
        /// Methode
        /// </summary>
        /// <param name="vecs"></param>
        /// <returns>Vecteur</returns>
        public Vector Add(params Vector[] vecs)
        {
            base.CalculateSum(vecs);
            return vecs[0];
        }
        public Vector MultiplyBy(double fac)
        {
            base.CalculatePoduct(fac);
            return new Vector();
        }
        public double Dotproduct(Vector v2)
        {
            double skalarprodukt = this.x * v2.x + this.y * v2.y + this.z * v2.z;
            return skalarprodukt;
        }
        public Vector CrossProduct(Vector v2)
        {
            Vector vfinal = new Vector();
            vfinal.x = this.y * v2.z - this.z * v2.y;
            vfinal.y = this.z * v2.x - this.x * v2.z;
            vfinal.z = this.x * v2.y - this.y * v2.x;
            Console.WriteLine($"Das Crossproduct ergibt: ({vfinal.x}; {vfinal.y}; {vfinal.z})");
            return vfinal;
        }
        public Vector Normalize()
        {
            Vector norm_vektor = new Vector();
            double norm = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            norm_vektor.x = Math.Round(this.x / norm, 3);
            norm_vektor.y = Math.Round(this.y / norm, 3);
            norm_vektor.z = Math.Round(this.z / norm, 3);
            Console.WriteLine($"Der normalisierte Vektor ist: ({norm_vektor.x}; {norm_vektor.y}; {norm_vektor.z})");
            return norm_vektor;
        }
        /// <summary>
        /// colinearite
        /// </summary>
        /// <param name="vecs"></param>
        /// <returns></returns>
        public bool AreCollinear(params Vector[] vecs)
        {
            bool colinear = false;
            double c1 = vecs[0].x / vecs[1].x;
            double c2 = vecs[0].y / vecs[1].y;
            double c3 = vecs[0].z / vecs[1].z;
            if (c1 == c2 && c2 == c3)
            {
                colinear = true;
            }
            else
            {
                IsCollinear(Tolerance, vecs);
            }

            return colinear;
        }


        public override string ToString()
        {
            return $"(Vector) {base.ToString()}";
        }
        /// <summary>
        /// Verifie l egalite entre l instance et objet
        /// </summary>
        /// <param name="obj">objet a verifie</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Vector operator +(Vector v1, Vector v2)
        {

            return new Vector(v2.x + v1.x, v2.y + v1.y, v2.z + v1.z);
        }

        public bool IsCollinear(double Toleranz, params Vector[] vecs)
        {
            bool ok = false;
            double c = vecs[0].x / vecs[1].x, c1 = vecs[0].y / vecs[1].y, c2 = vecs[0].z / vecs[1].z;
            for (double i = 0; i <= Tolerance; i += 0.01)
            {
                if (c != c1)
                {
                    if (c > c1)
                    {
                        if (c == c1 + i)
                        {
                            for (double j = 0; j <= Tolerance; j++)
                            {
                                if (c > c2)
                                {
                                    if (c == c2 + j)
                                    {
                                        ok = true;
                                    }
                                }
                                else
                                {
                                    if (c2 == c + j)
                                    {
                                        ok = true;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (c1 == c + i)
                        {
                            for (double j = 0; j <= Tolerance; j++)
                            {
                                if (c1 > c2)
                                {
                                    if (c1 == c2 + j)
                                    {
                                        ok = true;
                                    }
                                }
                                else
                                {
                                    if (c2 == c1 + j)
                                    {
                                        ok = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return ok;
        }
    }
}
