using Patterns.Factory_Method.Animals;

namespace Patterns.Abstract_Factory.Interfaces
{
    interface IReadWriteBird
    {
        Bird ReadBird(string s);
        string WriteBird(Bird bird);
    }
}
