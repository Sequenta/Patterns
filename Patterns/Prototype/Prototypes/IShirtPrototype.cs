namespace Prototype.Prototypes
{
    public interface IShirtPrototype
    {
        bool Arms { get; set; }
        string Body { get; set; }

        IShirtPrototype Clone();
    }
}