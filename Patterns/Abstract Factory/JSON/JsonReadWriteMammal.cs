using Patterns.Abstract_Factory.Interfaces;
using Patterns.Factory_Method.Animals;
using System.Text.Json;

namespace Patterns.Abstract_Factory.JSON
{
    class JsonReadWriteMammal : IReadWriteMammal
    {
        public Mammal ReadMammal(string s)
        {
            Mammal? mammal =
                JsonSerializer.Deserialize<Mammal>(s);
            return mammal!;
        }

        public string WriteMammal(Mammal mammal)
        {
            return JsonSerializer.Serialize(mammal);
        }
    }
}
