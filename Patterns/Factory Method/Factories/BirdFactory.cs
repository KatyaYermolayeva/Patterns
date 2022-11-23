using Patterns.Factory_Method.Animals;

namespace Patterns.Factory_Method.Factories
{
    class BirdFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Bird
            {
                Name = name
            };
        }
    }
}
