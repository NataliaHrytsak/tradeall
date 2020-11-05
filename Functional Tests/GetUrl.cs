using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestProject2
{
    public partial class GetUrl : Form
    {
        WebBrowser MuLoader = new WebBrowser()
        {
            ScriptErrorsSuppressed = false
        };
        public GetUrl()
        {
            InitializeComponent();
        }

        private void GetUrl_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void readHreff(HtmlElementCollection HrefList)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = HrefList.Count + 1;     
            foreach (HtmlElement HTML in HrefList)
            {        
                if (HTML.InnerHtml != null)
                {

                    Links.Items.Add(HTML.GetAttribute("href"));
                }
                progressBar1.Value++;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int c = 0;
            progressBar1.Value++;
            if (MuLoader.Document != null)
                c = MuLoader.Document.Links.Count;
            if (c > 0)
            {
                timer1.Stop();
                readHreff(MuLoader.Document.Links);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
