namespace Patterns.Factory_Method.Animals
{
    class Fish : IAnimal
    {
        public string Name { get; set; }
        public bool IsFreshWater { get; set; }

        public string Print()
        {
            return $"This is a fish named {Name}. It lives in {(IsFreshWater ? "fresh" : "sea")} water";
        }
    }
}
