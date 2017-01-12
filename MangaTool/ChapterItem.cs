using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace MangaTool
{
     [Serializable]
    public class ChapterItem
    {

        string chap_name;

        public string Chap_name
        {
            get { return chap_name; }
            set { chap_name = value; }
        }


        string chap_create;

        public string Chap_create
        {
            get { return chap_create; }
            set { chap_create = value; }
        }


        string chap_link;

        public string Chap_link
        {
            get { return chap_link; }
            set { chap_link = value; }
        }

        
        List<ImgChapter> listImg = new List<ImgChapter>();
       
        public List<ImgChapter> ListImg
        {
            get { return listImg; }
            set { listImg = value; }
        }
    }
}
