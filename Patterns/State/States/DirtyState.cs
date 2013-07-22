using System;

namespace State.States
{
    public class DirtyState:ShirtState
    {
        public DirtyState(Shirt shirt, int timesWeared)
        {
            Shirt = shirt;
            TimesWeared = timesWeared;
        }

        public DirtyState(ShirtState state)
            :this(state.Shirt,state.TimesWeared)
        {
            
        }

        public override void Wear()
        {
            TimesWeared += 1;
            CheckState();
        }

        public void CheckState()
        {
            if (TimesWeared > 3)
            {
                Shirt.State = new DirtyState(this);
                Console.WriteLine("This t-shirt is too dirty. You must wash it!");
            }
        }

        public override string ToString()
        {
            return "Dirty";
        }
    }
}