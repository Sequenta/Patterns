using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main()
        {
            var articleNumber = new ArticleNumber("N56B");
            Console.WriteLine("Article number: {0}", articleNumber.ShortNotation);
            var articleInterpreterTree = new List<ArticleNumberInterpreter>()
                {
                    new ManufacturerInterpreter(),
                    new SizeInterpreter(),
                    new ColorInterpreter()
                };
            foreach (var articleNumberInterpreter in articleInterpreterTree)
            {
                articleNumberInterpreter.InterpretArticlePart(articleNumber);
            }
            Console.WriteLine("Description: {0}",articleNumber.Description);
            Console.ReadKey();
        }
    }
}
