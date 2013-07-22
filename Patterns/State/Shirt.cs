using System;
using State.States;

namespace State
{
    public class Shirt
    {
        public ShirtState State { get; set; }
        public string Label { get; set; }

        public Shirt(string label)
        {
            Label = label;
            State = new CleanState(this,0);
        }

        public void Wear()
        {
            State.Wear();
            Console.WriteLine("This t-shirt is now in {0} state",State.ToString());
        }

        public void Wash()
        {
            Console.WriteLine("Washing...");
            State = new CleanState(this,0);
            Console.WriteLine("This t-shirt is clean now!");
        }
    }
}