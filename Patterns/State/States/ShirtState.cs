namespace State.States
{
    public abstract class ShirtState
    {
        private Shirt shirt;
        public Shirt Shirt
        {
            get { return shirt; }
            set { shirt = value; }
        }

        private int timesWeared;
        public int TimesWeared
        {
            get { return timesWeared; }
            set { timesWeared = value; }
        }

        public abstract void Wear();
    }
}