using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaTool
{
    public class InfomationManga
    {
        string manga_property;

        public string Manga_property
        {
            get { return manga_property; }
            set { manga_property = value; }
        }
        string manga_tagcha;

        public string Manga_tagcha
        {
            get { return manga_tagcha; }
            set { manga_tagcha = value; }
        }
        string manga_tagcon="li";

        public string Manga_tagcon
        {
            get { return manga_tagcon; }
            set { manga_tagcon = value; }
        }
        bool manga_removehtml = true;

        public bool Manga_removehtml
        {
            get { return manga_removehtml; }
            set { manga_removehtml = value; }
        }
        int manga_index = 0;

        public int Manga_index
        {
            get { return manga_index; }
            set { manga_index = value; }
        }
        string mana_value = "";

        public string Mana_value
        {
            get { return mana_value; }
            set { mana_value = value; }
        }
   

    }
}
