namespace Interpreter
{
    public class SizeInterpreter:ArticleNumberInterpreter
    {
        public override void InterpretArticlePart(ArticleNumber number)
        {
            var sizeShort = number.ShortNotation.Substring(0, 2);
            number.ShortNotation = number.ShortNotation.Substring(2);
            number.Description += "size of " + sizeShort + " ";
        }
    }
}