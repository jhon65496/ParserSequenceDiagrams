using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace Parser.Core.Habra
{
    class HabraParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list  = new List<string>();
            // var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link"));
            // var items = document.QuerySelectorAll("a > span").Where(item => item.ClassName != null && item.ClassName.Contains("tm-title tm-title_h2"));
            var items = document.QuerySelectorAll("div.tm-article-snippet.tm-article-snippet > h2 > a > span");

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
