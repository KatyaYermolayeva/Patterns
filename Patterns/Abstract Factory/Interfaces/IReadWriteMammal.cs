using Patterns.Factory_Method.Animals;

namespace Patterns.Abstract_Factory.Interfaces
{
    interface IReadWriteMammal
    {
        Mammal ReadMammal(string s);
        string WriteMammal(Mammal mammal);
    }
}
