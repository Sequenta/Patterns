using System;

namespace Memento
{
    public class Order
    {
        public string Label { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Number { get; set; }

        public OrderMemento SaveOrder()
        {
            return new OrderMemento(Label,Color,Size,Number);
        }

        public void RestoreFromStorage(OrderMemento memento)
        {
            Label = memento.Label;
            Color = memento.Color;
            Size = memento.Size;
            Number = memento.Number;
        }

        public override string ToString()
        {
            return string.Format("Order:{0}Label: {1}{0}Color: {2}{0}Size: {3}{0}Number: {4}{0}", Environment.NewLine,
                                 Label, Color, Size, Number);
        }
    }
}