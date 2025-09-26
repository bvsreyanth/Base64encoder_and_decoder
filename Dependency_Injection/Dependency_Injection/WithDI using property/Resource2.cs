using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.WithDI_using_property
{
    public class Resource2:IClass
    {
        public void Serve()
        {
            Console.WriteLine("Resource2 is Initialized");
        }
    }
}
