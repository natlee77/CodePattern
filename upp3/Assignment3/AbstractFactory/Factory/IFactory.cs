namespace Assignment2.AbstractFactory
{
    interface IFactory
    {
        IAnimal CreateAnimal(string type);
        
    }
}