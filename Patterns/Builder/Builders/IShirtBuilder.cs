namespace Builder.Builders
{
    public interface IShirtBuilder
    {
        void BuildBody();
        void BuildArms();
        Shirt GetResult();
    }
}