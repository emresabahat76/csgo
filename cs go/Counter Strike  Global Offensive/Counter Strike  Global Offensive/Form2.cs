using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace Counter_Strike__Global_Offensive
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Lütfen düzgün bişeyler giriniz..");
            }else
            {
                /*
                Uri url = new Uri("https://csgosquad.com/search/" + textBox1.Text);

                WebClient client = new WebClient();
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("</tbody>");

                foreach(var baslik in basliklar)
                {
                    string link = baslik.Attributes["href"].Value;
                    listBox1.Items.Add(baslik.InnerText);
                }
                */
                string adres = "https://csgosquad.com/search/" + textBox1.Text; //1
                WebRequest istek = HttpWebRequest.Create(adres); //2
                WebResponse cevap; //3
                cevap = istek.GetResponse(); //4
                StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream()); //5
                string gelen = donenBilgiler.ReadToEnd(); //6
                int titleIndexBaslangici = gelen.IndexOf("<tbody>") + 1; //7
                int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</table>");

                label1.Text = gelen.Substring(gelen.IndexOf("<tbody>") + 1, gelen.Substring(titleIndexBaslangici).IndexOf("</table>"));

            }
        }
    }
}
