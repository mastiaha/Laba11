using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    struct Linejnoe
    {
        double k;
        double b;

        public Linejnoe(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0 && b == 0)
                return "Корнем является любое число";
            if (k == 0)
                return "Корней нет";
            double resultat1 = -b / k;
            return $"Корень уравнения {resultat1}";
            

            
            
        }
    }
}
