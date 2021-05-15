using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parser_in_HTMLAgilityPack
{
    class Program
    {
        static void Main(string[] args)
        {
            string WebSiteSource = "https://vc.ru/dev/148017-parsing-na-c-s-htmlagilitypack";
            HtmlDocument HtmlDocumentation = new HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };

            HtmlDocumentation = web.Load(WebSiteSource);

            string Node_Type = "div";
            string Class_Name = "l-island-a";

            HtmlNodeCollection htmlNodes = HtmlDocumentation.DocumentNode.SelectNodes(string.Format($"//{Node_Type}[@class='{Class_Name}']"));


            if(htmlNodes != null)
            {
                foreach(HtmlNode node in htmlNodes)
                {
                    Console.WriteLine(node.InnerText);
                }
            }
        }
    }
}
