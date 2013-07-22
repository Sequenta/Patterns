namespace Memento
{
    public class OrderMemento
    {
        public string Label { get;  set; }
        public string Color { get;  set; }
        public string Size { get;  set; }
        public int Number { get;  set; }

        public OrderMemento(string label,string color,string size,int number)
        {
            Label = label;
            Color = color;
            Size = size;
            Number = number;
        }
    }
}