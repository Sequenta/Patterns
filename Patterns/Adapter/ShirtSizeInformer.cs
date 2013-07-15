namespace Adapter
{
    public static class ShirtSizeInformer
    {
        public static string GetSize(ISizeInfo shirt)
        {
            return shirt.Size();
        }
    }
}