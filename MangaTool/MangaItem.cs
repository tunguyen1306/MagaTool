using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaTool
{
    [Serializable]
    public class MangaItem
    {
        string manga_name;

        public string Manga_name
        {
            get { return manga_name; }
            set { manga_name = value; }
        }
        string manga_auth;

        public string Manga_auth
        {
            get { return manga_auth; }
            set { manga_auth = value; }
        }


        string maga_type;

        public string Maga_type
        {
            get { return maga_type; }
            set { maga_type = value; }
        }

      
        string manga_img;

        public string Manga_img
        {
            get { return manga_img; }
            set { manga_img = value; }
        }

      
        string manga_des;

        public string Manga_des
        {
            get { return manga_des; }
            set { manga_des = value; }
        }

       
        List<ChapterItem> listCha = new List<ChapterItem>();

        public List<ChapterItem> ListCha
        {
            get { return listCha; }
            set { listCha = value; }
        }
    }
}
