using S_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace S_Service
{
    [ServiceBehavior(AddressFilterMode =AddressFilterMode.Any)]
    public class CalculatorService : ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
