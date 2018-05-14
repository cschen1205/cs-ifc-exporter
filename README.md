# cs-ifc-exporter

.Net library to that export BIM IFC files as SVG, OBJ, XML, DAE, STEP, IGES files.

This project makes use of the [IfcOpenShell](http://ifcopenshell.org/ifcconvert.html)

# Install

```bash
Install-Package cs-ifc-exporter
```

# Usage

The sample codes below shows how to use the IfConvert to convert IFC files into OBJ, XML or other formats:

```cs 
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

```
