using Patterns.Abstract_Factory.Interfaces;
using Patterns.Abstract_Factory.JSON;

namespace Patterns.Abstract_Factory.Factories
{
    class JsonReadWriteFactory : IReadWriteFactory
    {
        public IReadWriteBird ReadWriteBird()
        {
            return new JsonReadWriteBird();
        }

        public IReadWriteFish ReadWriteFish()
        {
            return new JsonReadWriteFish();
        }

        public IReadWriteMammal ReadWriteMammal()
        {
            return new JsonReadWriteMammal();
        }
    }
}
