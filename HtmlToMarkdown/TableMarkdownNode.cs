using MarkdownMaker;

namespace HtmlToMarkdown
{
    public class TableMarkdownNode : MarkDownNode
    {
        public TableMarkdownNode(Table table)
        {
            this.Table = table;
        }

        public Table Table { get; private set; }

        public override string ToString()
        {
            return this.NewLine() + this.Table.ToMarkdown() + this.NewLine();
        }
    }
}