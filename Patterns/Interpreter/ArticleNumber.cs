namespace Interpreter
{
    public class ArticleNumber
    {
        public string ShortNotation { get; set; }
        public string Description { get; set; }

        public ArticleNumber(string shortNotation)
        {
            ShortNotation = shortNotation;
        }
    }
}