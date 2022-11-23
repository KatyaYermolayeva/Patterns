using Patterns.Factory_Method.Animals;

namespace Patterns.Factory_Method.Factories
{
    class MammalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Mammal
            {
                Name = name
            };
        }
    }
}
