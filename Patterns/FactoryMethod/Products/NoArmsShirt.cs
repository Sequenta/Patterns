namespace FactoryMethod.Products
{
    public class NoArmsShirt:IShirt
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public string Label { get; set; }
        public bool Arms { get; set; }

        public NoArmsShirt(string label)
        {
            Label = label;
            Arms = false;
        }

        public override string ToString()
        {
            return string.Format("This is {0} tshirt with no arms", Label);
        }
    }
}