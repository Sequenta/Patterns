namespace Builder.Builders
{
    public class AdidasBuilder:IShirtBuilder
    {
        private Shirt tshirt = new Shirt();

        public void BuildBody()
        {
            tshirt.AddPart("Blue body");
        }

        public void BuildArms()
        {
            tshirt.AddPart("no arms");
        }

        public Shirt GetResult()
        {
            return tshirt;
        }
    }
}