using System.Collections.Generic;

namespace Interpreter
{
    public class ColorInterpreter:ArticleNumberInterpreter
    {
        private Dictionary<string, string> colors;

        public ColorInterpreter()
        {
            colors = new Dictionary<string, string>
                {
                    {"B","Black"},
                    {"R","Red"},
                    {"Y","Yellow"}
                }; 
        }

        public override void InterpretArticlePart(ArticleNumber number)
        {
            var colorShort = number.ShortNotation.Substring(0, 1);
            string color;
            if (!colors.TryGetValue(colorShort, out color))
            {
                color = "Unknown color ";
            }
            number.Description += color + " ";
        }
    }
}