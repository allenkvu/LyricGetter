using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyricEngine.Engine;

namespace LyricEngine
{
    public class WebAddressManager
    {
        public String WebHandler(String webAddress)
        {
            String lyric = "Lyric will be here";
            if (webAddress != null)
            {
                if (webAddress.Contains("j-lyric.net/"))
                {
                    Jlyrics jlyrics = new Jlyrics();
                    lyric = jlyrics.JlyricsString(webAddress);
                }

                if (webAddress.Contains("music.jp"))
                {
                    Jlyrics jlyrics = new Jlyrics();
                    lyric = jlyrics.JlyricsString(webAddress);
                }
            }
            return lyric;
        }
    }
}
