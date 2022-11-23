using Patterns.Factory_Method.Animals;

namespace Patterns.Abstract_Factory.Interfaces
{
    interface IReadWriteFish
    {
        Fish ReadFish(string s);
        string WriteFish(Fish fish);
    }
}
