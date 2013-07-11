namespace AbstractFactory.Products
{
    public interface IShirt
    {
        string Size { get;set; }
        string Color { get; set; }
        string Label { get; set; }
        bool Arms { get; set; }
    }
}