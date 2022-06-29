using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5dn
{
    public class ComplexNumber
    {
        public float Re;
        public float Im;
        public ComplexNumber() { }
        public ComplexNumber(float re, float im)
        {
            Re = re;
            Im = im;
        }
        public override string ToString()
        {
            return string.Format("({0})+({1})i", Re, Im);
        }

    }
}
