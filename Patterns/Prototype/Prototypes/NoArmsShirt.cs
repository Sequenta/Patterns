namespace Prototype.Prototypes
{
    public class NoArmsShirt:IShirtPrototype
    {
        public bool Arms { get; set; }
        public string Body { get; set; }

        public NoArmsShirt()
        {
            Arms = false;
            Body = "simple body";
        }
        public IShirtPrototype Clone()
        {
            return MemberwiseClone() as IShirtPrototype;
        }
    }
}