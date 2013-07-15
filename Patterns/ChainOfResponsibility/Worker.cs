namespace ChainOfResponsibility
{
    public abstract class Worker
    {
        protected Worker upperWorker;

        public void SetUpperWorker(Worker worker)
        {
            upperWorker = worker;
        }

        public abstract void MakeBodyForShirt(Shirt shirt);
    }
}