using HtmlAgilityPack;
using System;
using System.Text;

namespace Parser_in_HTMLAgilityPack
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = "https://vc.ru/dev/148017-parsing-na-c-s-htmlagilitypack";
            HtmlDocument HtmlDoc = new HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };

            HtmlDoc = web.Load(html);

            HtmlNodeCollection htmlNodes = HtmlDoc.DocumentNode.SelectNodes("//h1[@class='content-title']");

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
