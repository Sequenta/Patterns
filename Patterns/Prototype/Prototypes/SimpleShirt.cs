namespace Prototype.Prototypes
{
    public class SimpleShirt:IShirtPrototype
    {
        public bool Arms { get; set; }
        public string Body { get; set; }

        public SimpleShirt()
        {
            Arms = true;
            Body = "simple body";
        }
        public IShirtPrototype Clone()
        {
            return MemberwiseClone() as IShirtPrototype;
        }
    }
}