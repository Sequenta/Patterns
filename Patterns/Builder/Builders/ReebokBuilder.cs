namespace Builder.Builders
{
    public class ReebokBuilder:IShirtBuilder
    {
        private Shirt tshirt = new Shirt();

        public void BuildBody()
        {
            tshirt.AddPart("Red body");
        }

        public void BuildArms()
        {
            tshirt.AddPart("short arms");
        }

        public Shirt GetResult()
        {
            return tshirt;
        } 
    }
}