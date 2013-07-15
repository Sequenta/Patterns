namespace Command
{
    public class OrderForShirts:IOrder
    {
        private readonly IDepartment performer;
        private readonly string shirtsColor;
        private readonly int numberOfShirts;

        public OrderForShirts(IDepartment performer,string shirtsColor,int numberOfShirts)
        {
            this.performer = performer;
            this.shirtsColor = shirtsColor;
            this.numberOfShirts = numberOfShirts;
        }

        public void Perform()
        {
           performer.MakeBatch(shirtsColor,numberOfShirts);
        }
    }
}