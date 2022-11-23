using Patterns.Factory_Method.Animals;

namespace Patterns.Factory_Method.Factories
{
    class FishFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Fish
            {
                Name = name
            };
        }
    }
}
