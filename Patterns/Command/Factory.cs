namespace Command
{
    public class Factory
    {
        private FirstDepartment firstDepartment;
        private SecondDepartment secondDepartment;

        public Factory()
        {
            firstDepartment = new FirstDepartment();
            secondDepartment = new SecondDepartment();
        }

        public void GetOrder(string shirtsColor, int numberOfShirts)
        {
            IOrder order;
            if (numberOfShirts<1000)
            {
                order = new OrderForShirts(firstDepartment, shirtsColor, numberOfShirts);
            }
            else
            {
                order = new OrderForShirts(secondDepartment, shirtsColor, numberOfShirts);
            }
            order.Perform();
        }
    }
}