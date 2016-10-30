using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _2310_XMLJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var xml="<Personel><Ad>Fatih</Ad></Personel>";
            XmlDocument doc = new XmlDocument();
            //XML işlemleri için kullanılan System.Xml Kütüphanesi içinde yer alan bir sınıf.
            //doc.LoadXml(xml); //string bir veri içerisinde xml varsa LoadXml metodu kullanılabilir. string türde bir parametre ister.
            doc.Load("Kisiler.xml"); //bir xml dosyasından yükleme yapmak için Load metodu kullanılır.
            XmlNodeList nodes = doc.GetElementsByTagName("Kisi");
            int sayac = 1;
            foreach (XmlNode siradakiElement in nodes)
            {
                lstKisiler.Items.Add(sayac+" "+ siradakiElement["Ad"].InnerText + " " + siradakiElement["Soyad"].InnerText + " " + siradakiElement["TcKimlik"].InnerText + " " + siradakiElement["Yas"].InnerText);
                sayac++;
                //hava durumu bilgilerini xml olarak çekicez.
            }
        }
    }
}
