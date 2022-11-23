namespace Patterns.Factory_Method.Animals
{
    class Bird : IAnimal
    {
        public string Name { get; set; }
        public bool CanFly { get; set; }  

        public string Print()
        {
            return $"This is a bird named {Name}. It can{(CanFly ? "" : "'t")} fly.";
        }
    }
}
