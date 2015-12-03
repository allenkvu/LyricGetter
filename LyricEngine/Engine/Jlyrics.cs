using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace LyricEngine.Engine
{
    class Jlyrics
    {
        public String JlyricsString(String webAddress)
        {
            //"http://j-lyric.net/artist/a002723/l001e83.html"

            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(webAddress);

            HtmlNode node = document.DocumentNode.SelectSingleNode("//p[@id='lyricBody']");

            System.Diagnostics.Debug.WriteLine(node.InnerHtml.ToString());
            return node.InnerHtml.ToString();



        }
    }
}
