﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlToMarkdown
{
    public class ParagraphMarkDownNode : MarkDownNode
    {
        public override string ToString()
        {
            return base.ToString().TrimStart() + NewLine() + NewLine();
        }
    }
}
