using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_parser
{
    internal class XmlParser:FileParser
    {
        public XmlParser(string str1) : base(str1)
        {
        }

        internal override string ParserFormat
        {
            get => ".xml";
        }

        internal override void Open()
        {
            Console.WriteLine($"{nameof(XmlParser)}: file {FileName}, Открытие");
        }
        internal override void Read()
        {
            Console.WriteLine($"{nameof(XmlParser)}: file {FileName},Чтение ");
        }

        internal override void Analize()
        {
            Console.WriteLine($"{nameof(XmlParser)}: file {FileName}, Анализ");
        }

        internal override void Close()
        {
            Console.WriteLine($"{nameof(XmlParser)}: file {FileName}, Закрытие");
        }
    }
}
