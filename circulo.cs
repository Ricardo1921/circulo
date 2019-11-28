using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class circulo
    {
        private double _r;
        public string raio { set => _r = Convert.ToDouble(value); }
        public string area => (Math.PI * (_r * _r)).ToString();
        public string perimetro => ((2 * Math.PI) * _r).ToString();
        public string diametro => (_r * 2).ToString();
    }
}
