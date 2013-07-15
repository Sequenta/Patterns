namespace ChainOfResponsibility
{
    public class Shirt
    {
        public string Material { get; private set; }

        public Shirt(string material)
        {
            Material = material;
        }
    }
}