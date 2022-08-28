using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_parser
{
        internal class HtmlParser : FileParser
        {
            public HtmlParser(string str1) : base(str1)
            {
            }
            internal override string ParserFormat
            {
                get => ".Html";
            }
        internal override void Open()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: file {FileName}, Открытие");
        }
        internal override void Read()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: file {FileName},Чтение ");
        }

        internal override void Analize()
            {
                Console.WriteLine($"{nameof(HtmlParser)}: file {FileName}, Анализ");
            }

            internal override void Close()
            {
                Console.WriteLine($"{nameof(HtmlParser)}: file {FileName}, Закрытие");
            }

            
        }
}

