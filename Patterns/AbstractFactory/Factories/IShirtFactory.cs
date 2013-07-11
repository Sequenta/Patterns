using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public interface IShirtFactory
    {
        IShirt MakeSimpleShirt(string size,string color);
        IShirt MakeNoArmsShirt(string size, string color);
    }
}