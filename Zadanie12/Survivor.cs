using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    public class Survivor
    {
        public string name;
        public double age;
        public int pclass;
        public int survived;


        public Survivor(string _name, string _age, string _pclass, string _survived)
        {
            name = _name;
            age =Convert.ToDouble(_age);
            pclass = Convert.ToInt32(_pclass);
            survived = Convert.ToInt32(_survived);

        }
    }
}
