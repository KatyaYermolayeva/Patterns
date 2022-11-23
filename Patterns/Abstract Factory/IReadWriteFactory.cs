using Patterns.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    internal interface IReadWriteFactory
    {
        public IReadWriteFish ReadWriteFish();
        public IReadWriteBird ReadWriteBird();
        public IReadWriteMammal ReadWriteMammal();
    }
}
