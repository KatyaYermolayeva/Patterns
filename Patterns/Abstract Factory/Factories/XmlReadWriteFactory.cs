using Patterns.Abstract_Factory.Interfaces;
using Patterns.Abstract_Factory.XML;

namespace Patterns.Abstract_Factory.Factories
{
    class XmlReadWriteFactory : IReadWriteFactory
    {
        public IReadWriteBird ReadWriteBird()
        {
            return new XmlReadWriteBird();
        }

        public IReadWriteFish ReadWriteFish()
        {
            return new XmlReadWriteFish();
        }

        public IReadWriteMammal ReadWriteMammal()
        {
            return new XmlReadWriteMammal();
        }
    }
}
