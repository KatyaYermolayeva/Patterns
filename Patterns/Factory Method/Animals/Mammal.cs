namespace Patterns.Factory_Method.Animals
{
    class Mammal : IAnimal
    {
        public string Name { get; set; }
        public string FurColor { get; set; }

        public string Print()
        {
            return $"This is a mammal named {Name}. It has {FurColor} fur.";
        }
    }
}
