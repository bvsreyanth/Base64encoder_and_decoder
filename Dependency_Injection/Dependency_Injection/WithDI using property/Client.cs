using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.WithDI_using_property
{
    public class Client
    {
        private IClass _service;
        // Property for property injection
        public IClass Service
        {
            set { _service = value; }
        }

        public void Serve()
        {
            _service.Serve();
        }
    }
}
