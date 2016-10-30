using _2310_XMLJSON.ServiceReference1;
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
    public partial class HavaDurumu : Form
    {
        public HavaDurumu()
        {
            InitializeComponent();
        }
        GlobalWeatherSoapClient client = new GlobalWeatherSoapClient("GlobalWeatherSoap");
        private void HavaDurumu_Load(object sender, EventArgs e)
        {
            
            //Web servise bağlanabilmek için bu class'dan bir örnek aldık. constructor'ında belirttiğimiz ise endpoint ismidir. Bu endpoint ismi app.config içerisinde yer alır.

            var xml=client.GetCitiesByCountry("Turkey");
            //MessageBox.Show(xml);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList nodes = doc.GetElementsByTagName("City");
            foreach (XmlNode siradakiElement in nodes)
            {
                cmbSehirler.Items.Add(siradakiElement.InnerText);
            }
        }

        private void cmbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliSehir = cmbSehirler.SelectedItem.ToString();
            var xml=client.GetWeather(seciliSehir, "Turkey");
            MessageBox.Show(xml);
        }
    }
}
