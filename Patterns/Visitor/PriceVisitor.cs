namespace Visitor
{
    public class PriceVisitor:IVisitor
    {
        public void Visit(IElement element)
        {
            var shirt = element as Shirt;
            shirt.Price -= shirt.Price*0.1;
        }
    }
}