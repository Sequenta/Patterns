namespace Singleton
{
    public class UniqueShirt
    {
        private static UniqueShirt instance;
        public string Autograph { get; private set; }

        private UniqueShirt()
        {
            Autograph = "Very famous football player!";
            instance = this;
        }

        public static UniqueShirt GetInstance()
        {
            return instance ?? new UniqueShirt();
        }
    }
}