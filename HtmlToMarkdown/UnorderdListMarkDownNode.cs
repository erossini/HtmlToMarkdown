﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlToMarkdown
{
    public class UnorderdListMarkDownNode : MarkDownNode
    {
        public override string NewLine()
        {
            return base.NewLine() + "  ";
        }
    }
}
