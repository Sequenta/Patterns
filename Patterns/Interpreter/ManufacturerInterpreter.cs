using System.Collections.Generic;

namespace Interpreter
{
    public class ManufacturerInterpreter:ArticleNumberInterpreter
    {
        private Dictionary<string, string> manufacturers;

        public ManufacturerInterpreter()
        {
            manufacturers = new Dictionary<string, string>
                {
                    {"N","Nike"},
                    {"A","Adidas"},
                    {"R","Reebok"}
                };    
        }

        public override void InterpretArticlePart(ArticleNumber number)
        {
            string manufacturerShort = number.ShortNotation.Substring(0,1);
            string manufacturer;
            if (!manufacturers.TryGetValue(manufacturerShort, out manufacturer))
            {
                manufacturer = "Unknown manufacturer ";
            }
            number.ShortNotation = number.ShortNotation.Substring(1);
            number.Description += manufacturer + " ";
        }
    }
}