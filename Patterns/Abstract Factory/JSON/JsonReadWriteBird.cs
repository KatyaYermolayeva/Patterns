using Patterns.Abstract_Factory.Interfaces;
using Patterns.Factory_Method.Animals;
using System.Text.Json;

namespace Patterns.Abstract_Factory.JSON
{
    class JsonReadWriteBird : IReadWriteBird
    {
        public Bird ReadBird(string s)
        {
            Bird? bird =
                JsonSerializer.Deserialize<Bird>(s);
            return bird!;
        }

        public string WriteBird(Bird bird)
        {
            return JsonSerializer.Serialize(bird);
        }
    }
}
