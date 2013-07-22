namespace TemplateMethod.ShirtFactories
{
    public abstract class ShirtFactory
    {
        public void MakeShirt()
        {
            MakeBody();
            Color();
            MakePrint();
        }

        public abstract void MakeBody();
        public abstract void Color();
        public abstract void MakePrint();
    }
}