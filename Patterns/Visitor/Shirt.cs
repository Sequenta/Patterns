namespace Visitor
{
    public class Shirt:IElement
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }

        public Shirt(string size,string color,string label,double price)
        {
            Size = size;
            Color = color;
            Label = label;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",Label,Size,Color,Price);
        }
    }
}