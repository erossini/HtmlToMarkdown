HtmlToMarkDown
==============

A HTML to Markdown converter in C# base on https://github.com/erossini/MarkdownMaker

Usage
=====

    var html = System.IO.File.ReadAllText("Index.html");
    var markdown = MarkDownDocument.FromHtml(html);
    Console.WriteLine(markdown);
    
