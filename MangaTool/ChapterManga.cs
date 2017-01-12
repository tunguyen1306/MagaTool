using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaTool
{
    public class ChapterManga
    {


        int index = 0;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        string property_name;

        public string Property_name
        {
            get { return property_name; }
            set { property_name = value; }
        }
        string tag_name_info;

        public string Tag_name_info
        {
            get { return tag_name_info; }
            set { tag_name_info = value; }
        }
        string tag_name_parent;

       
        bool tag_link = false;

        public bool Tag_link
        {
            get { return tag_link; }
            set { tag_link = value; }
        }

        string manga_value = "";

        public string Manga_value
        {
            get { return manga_value; }
            set { manga_value = value; }
        }

    }
}
