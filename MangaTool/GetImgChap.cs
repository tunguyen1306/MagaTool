using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko.DOM;

namespace MangaTool
{
    public partial class GetImgChap : UserControl
    {
        public delegate void DelegateEventFN(object sender, List<ImgChapter> list, string url,int index);
        public event DelegateEventFN ev_DelegateEventFN;
        public GetImgChap()
        {
            try
            {
                 InitializeComponent();
            }
            catch (Exception)
            {
                
             
            }
           
        }
        string query = "";
        string url;
        int index = 0;
        public void ReloadPage(string url,string jquery,int index)
        {
         
            query = jquery;
            this.url = url;
            this.index = index;
            geckoWebBrowser1.Navigate(url);
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }
     
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            GeckoScriptElement mGeckoScript = (GeckoScriptElement)geckoWebBrowser1.Document.CreateElement("script");// geckoWebBrowser1.Document.CreateElement("script");

          

            mGeckoScript.Type = "text/javascript";
            mGeckoScript.InnerHtml = @"jQuery(document).ready(function(){ jQuery('" + query + "').attr('id','data-manga');  });";
            if (geckoWebBrowser1.Document.GetElementsByTagName("head").Length>0)
            {
                geckoWebBrowser1.Document.GetElementsByTagName("head")[0].AppendChild(mGeckoScript);
                List<ImgChapter> list = new List<ImgChapter>();
                if (geckoWebBrowser1.Document.GetElementById("data-manga") != null)
                {
                    try
                    {

                        Gecko.Collections.IDomHtmlCollection<Gecko.GeckoElement> listNode = geckoWebBrowser1.Document.GetElementById("data-manga").GetElementsByTagName("img");
                        for (int i = 0; i < listNode.Length; i++)
                        {
                            ImgChapter item = new ImgChapter();
                            Gecko.GeckoElement el = listNode[i];
                            if (el.HasAttribute("src"))
                            {
                                item.Link = el.GetAttribute("src");
                            }

                            list.Add(item);
                        }
                        if (ev_DelegateEventFN != null)
                        {
                            ev_DelegateEventFN(this, list, url, index);
                        }
                        (sender as Timer).Tick -= timer1_Tick;
                        (sender as Timer).Stop();
                        return;
                    }
                    catch (Exception exc)

                    {
                        Debug.WriteLine("Erro:" + exc);

                        count++;
                        if (count > 2)
                        {
                            if (ev_DelegateEventFN != null)
                            {
                                ev_DelegateEventFN(this, null, url, index);
                            }
                            (sender as Timer).Tick -= timer1_Tick;
                            (sender as Timer).Stop();
                            
                            return;
                        }

                    }

                }
                else
                {
                    count++;
                    if (count>2)
                    {
                        if (ev_DelegateEventFN != null)
                        {
                            ev_DelegateEventFN(this, null, url, index);
                        }
                        (sender as Timer).Tick -= timer1_Tick;
                        (sender as Timer).Stop();
                        return;
                        
                    }
                    
                }

      
        
            }

        }
    }
}
