namespace State.States
{
    public class CleanState:ShirtState
    {
        public CleanState(Shirt shirt, int timesWeared)
        {
            Shirt = shirt;
            TimesWeared = timesWeared;
        }

        public CleanState(ShirtState state)
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
            if (TimesWeared >1)
            {
                Shirt.State = new NormalState(this);
            }
        }

        public override string ToString()
        {
            return "Clean";
        }
    }
}