using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_frac
{
    class Frac
    {
        int chisl;
        int znam;

        public int Chisl
        {
            get
            {
                return chisl;
            }
        }
        public int Znam
        {
            get
            {
                return znam;
            }
        }

        public Frac()
        {
            chisl = znam = 1;
        }
        public Frac(int c, int z)
        {
            if (z == 0)
            {
                throw new ApplicationException("0 can't be in denominator of fraction");
            }
            chisl = c;
            znam = z;

            this.Normalize();
        }

        private void Normalize() {
            if(znam < 0) {
                chisl *= -1;
                znam *= -1;
            }

            for(int i = 2; i < znam; i++) {
                if(chisl % i == 0 && znam % i == 0) {
                    chisl /= i;
                    znam /= i;
                }
            }
        }

        public override string ToString()
        {
            this.Normalize();

            if(chisl % znam == 0) {
                return ((int)(chisl / znam)).ToString();
            }

            string sign = "";
            int t_chisl = chisl;
            if(chisl < 0) {
                sign = "-";
                t_chisl *= -1;
            }

            if(t_chisl > znam) {
                return sign + (int)(t_chisl / znam) + "(" + (t_chisl % znam) + "/" + znam + ")";
            }

            return sign + "(" + t_chisl + "/" + znam + ")";
        }

        public static Frac operator *(Frac a, Frac b)
        {
            return new Frac(a.chisl * b.chisl, a.znam * b.znam);
        }
        public static Frac operator *(int k, Frac b)
        {
            return ((new Frac(k, 1)) * b);
        }
        public static Frac operator *(Frac a, int k)
        {
            return ((new Frac(k, 1)) * a);
        }

        public double ToDec()
        {
            return (1.0 * chisl) / znam;
        }

        public static bool operator >(Frac a, Frac b)
        {
            return a.ToDec() > b.ToDec();
        }
        public static bool operator >(Frac a, int k)
        {
            return a.ToDec() > k;
        }
        public static bool operator >(int k, Frac b)
        {
            return k > b.ToDec();
        }

        public static bool operator >=(Frac a, Frac b)
        {
            return a.ToDec() >= b.ToDec();
        }
        public static bool operator >=(Frac a, int k)
        {
            return a.ToDec() >= k;
        }
        public static bool operator >=(int k, Frac b)
        {
            return k >= b.ToDec();
        }

        public static bool operator <(Frac a, Frac b)
        {
            return a.ToDec() < b.ToDec();
        }
        public static bool operator <(Frac a, int k)
        {
            return a.ToDec() < k;
        }
        public static bool operator <(int k, Frac b)
        {
            return k < b.ToDec();
        }

        public static bool operator <=(Frac a, Frac b)
        {
            return a.ToDec() <= b.ToDec();
        }
        public static bool operator <=(Frac a, int k)
        {
            return a.ToDec() <= k;
        }
        public static bool operator <=(int k, Frac b)
        {
            return k <= b.ToDec();
        }

        public static bool operator ==(Frac a, Frac b)
        {
            return a.ToDec() == b.ToDec();
        }
        public static bool operator ==(Frac a, int k)
        {
            return a.ToDec() == k;
        }
        public static bool operator ==(int k, Frac b)
        {
            return k == b.ToDec();
        }

        public static bool operator !=(Frac a, Frac b)
        {
            return a.ToDec() != b.ToDec();
        }
        public static bool operator !=(Frac a, int k)
        {
            return a.ToDec() != k;
        }
        public static bool operator !=(int k, Frac b)
        {
            return k != b.ToDec();
        }

        public static Frac operator +(Frac a, Frac b)
        {
            int c = a.chisl * b.znam + b.chisl * a.znam;
            int z = a.znam * b.znam;
            return new Frac(c, z);
        }
        public static Frac operator +(int k, Frac b)
        {
            return ((new Frac(k, 1)) + b);
        }
        public static Frac operator +(Frac a, int k)
        {
            return ((new Frac(k, 1)) + a);
        }

        public static Frac operator -(Frac a, Frac b)
        {
            return a + (b * -1);
        }
        public static Frac operator -(int k, Frac b)
        {
            return k + (b * -1);
        }
        public static Frac operator -(Frac a, int k)
        {
            return a + (k * -1);
        }

        public static Frac operator /(Frac a, Frac b)
        {
            return a * (new Frac(b.znam, b.chisl));
        }
        public static Frac operator /(int k, Frac b)
        {
            return ((new Frac(k, 1)) / b);
        }
        public static Frac operator /(Frac a, int k)
        {
            return ((a / new Frac(k, 1)));
        }
    }
}
