namespace Builder.Builders
{
    public class NikeBuilder:IShirtBuilder
    {
        private Shirt tshirt = new Shirt();

        public void BuildBody()
        {
            tshirt.AddPart("Yellow body");
        }

        public void BuildArms()
        {
            tshirt.AddPart("long arms");
        }

        public Shirt GetResult()
        {
            return tshirt;
        } 
    }
}