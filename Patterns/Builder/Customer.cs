using Builder.Builders;

namespace Builder
{
    public class Customer
    {
        public void AskForShirt(IShirtBuilder shirtBuilder)
        {
            shirtBuilder.BuildBody();
            shirtBuilder.BuildArms();
        }
    }
}