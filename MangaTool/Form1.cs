﻿using System.Data.SqlClient;
using Gecko.DOM;
using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MangaTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        void GetIzManaga()
        {

          //  manga_name
//manga_auth
//manga_type
//manga_img
//manga_des
            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_name", Manga_tagcon = "li", Manga_index = 0, Manga_tagcha = "div.manga-info-top" });
            infomationMangaBindingSource.EndEdit();

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_auth", Manga_tagcon = "li", Manga_index = 1, Manga_tagcha = "div.manga-info-top" });
            infomationMangaBindingSource.EndEdit();

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_type", Manga_tagcon = "li", Manga_index = 6, Manga_tagcha = "div.manga-info-top" });
            infomationMangaBindingSource.EndEdit();

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_img", Manga_tagcon = "img", Manga_index = 0, Manga_tagcha = "div.manga-info-top" });
            infomationMangaBindingSource.EndEdit();

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_des", Manga_tagcon = "p", Manga_index = 0, Manga_tagcha = "div.manga-info-content" });
            infomationMangaBindingSource.EndEdit();



           // chap_name
//chap_create
//chap_link
            chapterMangaBindingSource.Add(new ChapterManga { Property_name = "chap_name", Tag_name_info ="span", Tag_link = false, Index = 0 });
            chapterMangaBindingSource.EndEdit();


            chapterMangaBindingSource.Add(new ChapterManga { Property_name = "chap_create", Tag_name_info = "span", Tag_link =false, Index = 2 });
            chapterMangaBindingSource.EndEdit();

            chapterMangaBindingSource.Add(new ChapterManga { Property_name = "chap_link", Tag_name_info = "span", Tag_link =true, Index = 0 });
            chapterMangaBindingSource.EndEdit();
            vungChap = ".vung-doc";
        
        }



        void GetTuoithodudoi()
        {

            //  manga_name
            //manga_auth
            //manga_type
            //manga_img
            //manga_des
            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_name", Manga_tagcon = "h2", Manga_index = 0, Manga_tagcha = "div.info > div.row" });
            infomationMangaBindingSource.EndEdit();

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_auth", Manga_tagcon = "span", Manga_index = 1, Manga_tagcha = "div.info > div.row" });
            infomationMangaBindingSource.EndEdit();

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_type", Manga_tagcon = "span", Manga_index = 2, Manga_tagcha = "div.info > div.row" });
            infomationMangaBindingSource.EndEdit();

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_img", Manga_tagcon = "img", Manga_index = 0, Manga_tagcha = "div.info > div.row" });
            infomationMangaBindingSource.EndEdit();

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = "manga_des", Manga_tagcon = "p", Manga_index = 0, Manga_tagcha = "div.info > div.info-content" });
            infomationMangaBindingSource.EndEdit();



            txtTagCha2.Text = "table.table-striped > tbody > tr";
            // chap_name
            //chap_create
            //chap_link
            chapterMangaBindingSource.Add(new ChapterManga { Property_name = "chap_name", Tag_name_info = "td", Tag_link = false, Index = 0 });
            chapterMangaBindingSource.EndEdit();


            chapterMangaBindingSource.Add(new ChapterManga { Property_name = "chap_create", Tag_name_info = "td", Tag_link = false, Index = 2 });
            chapterMangaBindingSource.EndEdit();

            chapterMangaBindingSource.Add(new ChapterManga { Property_name = "chap_link", Tag_name_info = "td", Tag_link = true, Index = 0 });
            chapterMangaBindingSource.EndEdit();
            vungChap = ".view-chapter";

        }

        int totalLoad = 10;
        private void btnAddSetting_Click(object sender, EventArgs e)
        {

            infomationMangaBindingSource.Add(new InfomationManga { Manga_property = cbbInfomation.SelectedItem.ToString(), Manga_tagcon = txtTagCon.Text, Manga_index = int.Parse(txtIndex.Text), Manga_tagcha = txtTagCha.Text });
            infomationMangaBindingSource.EndEdit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbInfomation.SelectedIndex = 0;
            cbbInfomation2.SelectedIndex = 0;
           GetIzManaga();
           // GetTuoithodudoi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                infomationMangaBindingSource.RemoveAt(e.RowIndex);
                infomationMangaBindingSource.EndEdit();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                chapterMangaBindingSource.RemoveAt(e.RowIndex);
                chapterMangaBindingSource.EndEdit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            chapterMangaBindingSource.Add(new ChapterManga { Property_name = cbbInfomation2.SelectedItem.ToString(), Tag_name_info = txtTagCon2.Text, Tag_link = chkCheck2.Checked, Index = int.Parse(txtIndex2.Text) });
            chapterMangaBindingSource.EndEdit();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            check = false;
            geckoWebBrowser1.Navigate(txtUrl.Text);
            geckoWebBrowser1.DocumentCompleted += geckoWebBrowser1_DocumentCompleted;
        }
        bool check = false;
        void geckoWebBrowser1_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if (!check)
            {
                GeckoScriptElement mGeckoScript = (GeckoScriptElement)geckoWebBrowser1.Document.CreateElement("script");// geckoWebBrowser1.Document.CreateElement("script");

                string sxript = "";
                for (int j = 0; j < infomationMangaBindingSource.Count; j++)
                {
                    infomationMangaBindingSource.Position = j;
                    InfomationManga chap = infomationMangaBindingSource.Current as InfomationManga;
                    sxript += "jQuery('" + chap.Manga_tagcha + "').addClass('info-data'); ";
                }

                mGeckoScript.Type = "text/javascript";
                mGeckoScript.InnerHtml = @"jQuery(document).ready(function(){  " + sxript + "                   jQuery('" + txtTagCha2.Text + "').each(function(i){jQuery(this).attr('id','row_'+i);}); jQuery('" + txtTagCha2.Text + "').addClass('row-data');            });";
                geckoWebBrowser1.Document.GetElementsByTagName("head")[0].AppendChild(mGeckoScript);
                check = true;
                button1_Click_1(null, null);
            }
            //  geckoWebBrowser1.Document.ad

            //  geckoWebBrowser1.docume.GetElementsByTagName("head")(0).AppendChild(mGeckoScript)
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            /*  HtmlElement head = geckoWebBrowser1.Document.GetElementsByTagName("head")[0];
              HtmlElement script = geckoWebBrowser1.Document.CreateElement("script");
              IHTMLScriptElement domElement = (IHTMLScriptElement)script.DomElement;
              domElement.text = @"jQuery(document).ready(function(){
              jQuery('ul.manga-info-text li').each(function(i){jQuery(this).attr('id','li_'+i)});
              jQuery('div.row').each(function(i){jQuery(this).attr('row_'+i);});
              });"; // put your script here;
              head.AppendChild(script);*/

        }
        MangaItem item = new MangaItem();
        private void button1_Click_1(object sender, EventArgs e)
        {

            var IdAdvertManga=0;
            var IdChapterManga = 0;
            listLinkError = new List<string>();
            List<InfomationManga> info = new List<InfomationManga>();
            List<Gecko.GeckoNode> listNode = geckoWebBrowser1.Document.GetElementsByClassName("info-data").ToList();
            for (int i = 0; i < listNode.Count; i++)
            {
              
                Gecko.GeckoElement node = listNode[i] as Gecko.GeckoElement;
                for (int j = 0; j < infomationMangaBindingSource.Count; j++)
                {
                    infomationMangaBindingSource.Position = j;
                    InfomationManga chap = infomationMangaBindingSource.Current as InfomationManga;
                    try
                    {
                        if (node.GetElementsByTagName(chap.Manga_tagcon).Length > 0)
                        {
                            Gecko.GeckoElement nodeinfo = (Gecko.GeckoElement)node.GetElementsByTagName(chap.Manga_tagcon)[chap.Manga_index];
                            if (chap.Manga_tagcon == "img")
                            {
                                chap.Mana_value = nodeinfo.GetAttribute("src").IndexOf("http") != -1 ? nodeinfo.GetAttribute("src") : geckoWebBrowser1.Document.Location.Host+nodeinfo.GetAttribute("src");
                            }
                            else
                            {
                                chap.Mana_value = nodeinfo.TextContent.Replace("\n", "").Replace("\t","");
                            }
                            switch (chap.Manga_property)
                            {
                                case "manga_name":
                                    item.Manga_name = chap.Mana_value;
                                    break;
                                case "manga_auth":
                                    item.Manga_auth = chap.Mana_value;
                                    break;
                                case "manga_type":
                                    item.Maga_type = chap.Mana_value;
                                    break;
                                case "manga_img":
                                    item.Manga_img = chap.Mana_value;
                                    break;
                                case "manga_des":
                                    item.Manga_des = chap.Mana_value;
                                    break;
                                default:
                                    break;
                            }
                            info.Add(chap);
                            if (j==0 && i==0)
                            {
                             
                                var sqlAdd = "insert into tblAdvertMangas values (N'" + item.Manga_name.Replace("  ", " ").Trim() + "',N'" + item.Manga_des + "',N'" + chap.Mana_value.Trim() + "',1,1,1,1,'')";
                                Tools.ExcuteDatasetSql(sqlAdd);
                                var sqlgetId = "select top 1 IdAdvertManga from tblAdvertMangas where NameAdvertManga=N'" + item.Manga_name.Replace("  ", " ").Trim() + "' order by IdAdvertManga desc";
                                var dtGetID = Tools.ExcuteDatasetSql(sqlgetId);
                                IdAdvertManga =(int) dtGetID.Tables[0].Rows[0]["IdAdvertManga"];


                            }
                            
                        }
                    }
                    catch (Exception)
                    {

                    }


                    // info.Add(chap);
                }
            }


           

            List<ChapterManga> list = new List<ChapterManga>();
            listNode = geckoWebBrowser1.Document.GetElementsByClassName("row-data").ToList();
            for (int i = listNode.Count - 1; i >= 0; i--)
            {
                ChapterItem itemChap = new ChapterItem();
                Gecko.GeckoElement node = listNode[i] as Gecko.GeckoElement;
                for (int j = 0; j < chapterMangaBindingSource.Count; j++)
                {
                    chapterMangaBindingSource.Position = j;
                    ChapterManga chap = chapterMangaBindingSource.Current as ChapterManga;

                    Gecko.GeckoElement nodeinfo = (Gecko.GeckoElement)node.GetElementsByTagName(chap.Tag_name_info)[chap.Index];

                    if (chap.Tag_link)
                    {
                        chap.Manga_value = nodeinfo.GetElementsByTagName("a")[0].GetAttribute("href");


                    }
                    else
                    {
                        chap.Manga_value = nodeinfo.TextContent;
                    }
                    switch (chap.Property_name)
                    {
                        case "chap_name":
                            itemChap.Chap_name = chap.Manga_value;
                            break;
                        case "chap_create":
                            itemChap.Chap_create = chap.Manga_value;
                            break;
                        case "chap_link":
                            itemChap.Chap_link = chap.Manga_value;
                            break;
                        default:
                            break;
                    }

                }
            
                item.ListCha.Add(itemChap);
                var sqlAddChapter = "insert into tblChapterMangas values (N'" + itemChap.Chap_name.Replace("  ", " ").Trim() + "',1,"+IdAdvertManga+")";
                Tools.ExcuteDatasetSql(sqlAddChapter);
                var sqlgetIdChapter = "select top 1 IdChapterManga from tblChapterMangas where NameChapterManga=N'" + itemChap.Chap_name.Replace("  ", " ").Trim() + "' order by IdChapterManga desc";
                var dtGetIDChapter = Tools.ExcuteDatasetSql(sqlgetIdChapter);
                IdChapterManga = (int)dtGetIDChapter.Tables[0].Rows[0]["IdChapterManga"];
            }
            for (int i = 0; i < totalLoad; i++)
            {
                if (i < item.ListCha.Count)
                {
                    GetImgChap ff = new GetImgChap();
                    ff.ReloadPage(item.ListCha[i].Chap_link, vungChap, i);
                    ff.ev_DelegateEventFN += ff_ev_DelegateEventFN;
                    flowLayoutPanel1.Controls.Add(ff);
                    indexP=i;
                }
                else
                {
                    break;
                }
            }
          
         
           
        
        }
        string urlWeb = "http://manga.vangia.net/file";
        string vungChap = ".vung-doc";
        int indexP = 0;
        List<String> listLinkError = new List<string>();
        void ff_ev_DelegateEventFN(object sender, List<ImgChapter> list, string url,int index)
        {

            if (list == null)
            {
                bool check = false;
                foreach (String str in listLinkError)
                {
                    if (str == url)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    listLinkError.Add(url);
                }
               
            if (indexP < item.ListCha.Count - 1)
                {

                    this.indexP++;
                    (sender as GetImgChap).ReloadPage(item.ListCha[indexP].Chap_link, vungChap, indexP);

                }
                else
                {
                    flowLayoutPanel1.Controls.Remove(sender as GetImgChap);
                }
            }
            else
            {

               

           

                Debug.WriteLine(item.ListCha[index].Chap_name + "_" + url + "_" + list.Count);
                item.ListCha[index].ListImg = list;
                string key = YLProject.AppCode.ClsFuntion.key_for_img(item.Manga_name).Replace(":","-").Replace("--","-");
                if (!Directory.Exists(urlWeb + "/" + key))
                {
                    Directory.CreateDirectory(urlWeb + "/" + key);
                }
                string path = urlWeb + "/" + key + "/" + YLProject.AppCode.ClsFuntion.key_for_img(item.ListCha[index].Chap_name).Replace(":", "-").Replace("--", "-");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                ChapterItem itemchap = item.ListCha[index];
                //for (int i = 0; i < item.ListCha[index].ListImg.Count; i++)
                //{
                //    var sqlAddChapter = "insert into tblImgMangas values ('" + item.ListCha[index].ListImg[i].Link + "'," + IdChapterManga + ",1)";
                //    Tools.ExcuteDatasetSql(sqlAddChapter);
                //}
                BackgroundWorker wk1 = new BackgroundWorker();
                wk1.WorkerReportsProgress = true;
                wk1.WorkerSupportsCancellation = true;
                wk1.ProgressChanged += (s, e) =>
                {
                    Debug.WriteLine(e.ProgressPercentage * (e.UserState as ChapterItem).ListImg.Count / 100 + " %_" + (e.UserState as ChapterItem).Chap_name);
                };
                wk1.DoWork += (s, e) =>
                {
                    for (int j = 0; j < (e.Argument as ChapterItem).ListImg.Count; j++)
                    {
                       
                        using (WebClient client = new WebClient())
                        {
                            
                            if ((e.Argument as ChapterItem).ListImg[j].Link.Trim().Length>0)
                            {
                                client.DownloadFileAsync(new Uri((e.Argument as ChapterItem).ListImg[j].Link), path + "/" + j + ".jpg");
                              
                                //client.DownloadFile((e.Argument as ChapterItem).ListImg[j].Link, path + "/" + j + ".jpg");

                                (s as BackgroundWorker).ReportProgress(j, (e.Argument as ChapterItem));
                              /*  client.DownloadFileCompleted += (ss, ee) =>
                                {


                                   
                                };*/
                            }
                        
                        }
                    }
                };
              //  wk1.RunWorkerAsync(itemchap);

                if (indexP < item.ListCha.Count - 1)
                {
                    this.indexP++;
                    (sender as GetImgChap).ReloadPage(item.ListCha[indexP].Chap_link, vungChap, indexP);

                }
                else
                {
                    //for (int i = 0; i < item.ListCha[index].ListImg.Count; i++)
                    //{
                    //    var sqlAddChapter = "insert into tblImgMangas values ('" + item.ListCha[index].ListImg[i].Link + "'," + IdChapterManga + ",1)";
                    //    Tools.ExcuteDatasetSql(sqlAddChapter);
                    //}


                    flowLayoutPanel1.Controls.Remove(sender as GetImgChap);
                    if (flowLayoutPanel1.Controls.Count == 0)
                    {

                        BackgroundWorker wk = new BackgroundWorker();
                        wk.WorkerReportsProgress = true;
                        wk.WorkerSupportsCancellation = true;
                        wk.DoWork += (s, e) =>
                        {
                            MangaItem itmne = (e.Argument as MangaItem);

                            foreach (var charA in itmne.ListCha)
                            {
                                var sqlgetIdChapter = "select top 1 IdChapterManga from tblChapterMangas where NameChapterManga=N'" + charA.Chap_name.Replace("  ", " ").Trim() + "' order by IdChapterManga desc";
                                var dtGetIDChapter = Tools.ExcuteDatasetSql(sqlgetIdChapter);
                                var IdChapterManga = (int)dtGetIDChapter.Tables[0].Rows[0]["IdChapterManga"];
                                var memoryStream = new MemoryStream();
                                var streamWriter = new StreamWriter(memoryStream, System.Text.Encoding.UTF8);
                                new XmlSerializer(typeof(ChapterItem)).Serialize(streamWriter, charA);
                                memoryStream.Seek(0, SeekOrigin.Begin);
                                var streamReader = new StreamReader(memoryStream, System.Text.Encoding.UTF8);
                                var utf8EncodedXml = streamReader.ReadToEnd();
                                memoryStream.Flush();
                                memoryStream.Close();
                                streamReader.Close();
                                XmlDocument xdoc = new XmlDocument();
                                xdoc.LoadXml(utf8EncodedXml);
                                if (!Directory.Exists(urlWeb + "/" + key))
                                {
                                    Directory.CreateDirectory(urlWeb + "/" + key);
                                }
                                xdoc.Save(urlWeb + "/" + key + "/truyen" + item.Manga_name.Replace("  ", " ").Trim() + ".xml");
                                var sqlAddChapter = "insert into tblImgMangas values ('" + urlWeb + "/" + key + "/truyen" + charA.Chap_name.Replace(":", "-").Replace("--", "-") + ".xml" + "'," + IdChapterManga + ",1)";
                                Tools.ExcuteDatasetSql(sqlAddChapter);
                            }

                          
                            
                        };
                        wk.ProgressChanged += (s, e) =>
                        {
                        };
                        wk.RunWorkerCompleted += (s, e) =>
                        {
                        };
                        wk.RunWorkerAsync(item);


                    }
                }

            }
            

        }
    }
}