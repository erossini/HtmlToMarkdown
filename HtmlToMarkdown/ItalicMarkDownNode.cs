using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlToMarkdown
{
    public class ItalicMarkDownNode : MarkDownNode
    {
        public override string ToString()
        {
            return "_" + base.ToString() + "_";
        }
    }
}
