using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_parser
{
    internal abstract class FileParser
    {
        internal FileParser(string str1)
        {
            FileName = str1;
        }

        internal abstract string ParserFormat { get; }
        internal readonly string FileName;
        internal abstract void Read();
        internal abstract void Open();
        internal abstract void Analize();
        internal abstract void Close();
        internal virtual void Parse()
        {
            Open();
            Read();
            Analize();
            Close();
        }

        public static FileParser GetParser(string filename)
        {
            string[] words = filename.Split('.');
            switch (words[words.Length-1])
            {
                case "xml":
                    return new XmlParser(words[0]);
                case "rtf":
                    return new RtfParser(words[0]);
                case "html":
                    return new HtmlParser(words[0]);
                default:
                    return null;
            }

        }
    }
}
