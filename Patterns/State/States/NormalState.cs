namespace State.States
{
    public class NormalState:ShirtState
    {
        public NormalState(Shirt shirt, int timesWeared)
        {
            Shirt = shirt;
            TimesWeared = timesWeared;
        }

        public NormalState(ShirtState state)
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
            if (TimesWeared >2)
            {
                Shirt.State = new DirtyState(this);
            }
        }

        public override string ToString()
        {
            return "Normal";
        }
    }
}