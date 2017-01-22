using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Queue<String> qArrayLink = new Queue<string>();
        int count = 1;
        public int countRun = 0;
        bool run = false;
        private void button1_Click(object sender, EventArgs e)
        {
          var arrStr=  textBox1.Text.Split(',');
            foreach (var item in arrStr)
            {
                qArrayLink.Enqueue(item);
            }
            if(!run)
            {
                for (int i = 0; i < count; i++)
                {
                    if(qArrayLink.Count>0)
                        {
                        countRun++;
                        String link = qArrayLink.Dequeue();
                        Form1 f = new Form1(link);
                        f.Show();
                        f.FormClosed += F_FormClosed;
                    }
                  
                }
            }
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            countRun--;
         
                for (int i = 0; i < count; i++)
                {
                    if (countRun < count && qArrayLink.Count>0)
                    {
                        countRun++;
                        String link = qArrayLink.Dequeue();
                        Form1 f = new Form1(link);
                        f.Show();
                        f.FormClosed += F_FormClosed;
                    }else
                {
                    break;
                }
                }
            
          
            
        }
    }
}
