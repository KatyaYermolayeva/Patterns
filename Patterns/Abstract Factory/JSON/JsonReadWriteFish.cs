using Patterns.Abstract_Factory.Interfaces;
using Patterns.Factory_Method.Animals;
using System.Text.Json;

namespace Patterns.Abstract_Factory.JSON
{
    class JsonReadWriteFish : IReadWriteFish
    {
        public Fish ReadFish(string s)
        {
            Fish? fish =
                JsonSerializer.Deserialize<Fish>(s);
            return fish!;
        }

        public string WriteFish(Fish fish)
        {
            return JsonSerializer.Serialize(fish);
        }
    }
}
