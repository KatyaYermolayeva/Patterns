namespace Patterns.Factory_Method
{
    interface IAnimalFactory
    {
        IAnimal CreateAnimal(string name);
    }
}
