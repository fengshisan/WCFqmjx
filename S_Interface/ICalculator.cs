using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace S_Interface
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ICalculator”。
    [ServiceContract(Name ="CalculatorService",Namespace ="http://www.artech.com/")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x,double y);
    }
}
