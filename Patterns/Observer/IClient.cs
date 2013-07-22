namespace Observer
{
    public interface IClient
    {
        string Name { get; set; }
        void Update(string message);
    }
}