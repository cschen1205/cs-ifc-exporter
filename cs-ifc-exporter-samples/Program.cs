using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfcExport
{
    class Program
    {
        static void Main(string[] args)
        {
            IfcConvert.Convert("sample.ifc", "sample.obj");
            IfcConvert.Convert("sample.ifc", "sample.xml");
            IfcConvert.Convert("sample.ifc", "sample.dae");
            IfcConvert.Convert("sample.ifc", "sample.igs");
            IfcConvert.Convert("sample.ifc", "sample.svg");
        }
    }
}
