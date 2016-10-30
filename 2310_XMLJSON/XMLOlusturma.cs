using _2310_XMLJSON.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _2310_XMLJSON
{
    public partial class XMLOlusturma : Form
    {
        public XMLOlusturma()
        {
            InitializeComponent();
        }
        
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            //doc nesnesi dökümanı kasteder tüm elementlerin atasıdır (parent)...
            XmlNode urunlerNode = doc.CreateElement("Urunler");

            doc.AppendChild(urunlerNode); //Çocuk element olarak doc nesnesinin içine ekler.


            foreach(Products siradakiUrun in ent.Products)
            {
                //urunlerNode için yeni bir Urun node oluşturuyorum.
                XmlNode urunNode = doc.CreateElement("Urun");
                //Ad Attribute oluşturuluyor
                XmlAttribute AdAttr = doc.CreateAttribute("Ad");
                AdAttr.Value = siradakiUrun.ProductName;
                urunNode.Attributes.Append(AdAttr);
                //Fiyat Attribute oluşturuluyor
                XmlAttribute FiyatAttr = doc.CreateAttribute("Fiyat");
                FiyatAttr.Value = siradakiUrun.UnitPrice.ToString();
                urunNode.Attributes.Append(FiyatAttr);
                //Id Attribute oluşturuluyor
                XmlAttribute IdAttr = doc.CreateAttribute("Id");
                IdAttr.Value = siradakiUrun.ProductID.ToString();
                urunNode.Attributes.Append(IdAttr);
                //KategoriAdi Attribute oluşturuluyor
                XmlAttribute KatAdAttr = doc.CreateAttribute("KategoriAdi");
                var kat = siradakiUrun.Categories ?? new Categories { CategoryName = "KategoriYok" };
                //var kat = siradakiUrun.Categories==null ? new Categories { CategoryName = "KategoriYok" } : siradakiUrun.Categories;
                KatAdAttr.Value =kat.CategoryName;
                urunNode.Attributes.Append(KatAdAttr);
                
                //Urunler elementinin içerisine bir çocuk element olarak ekliyorum...
                urunlerNode.AppendChild(urunNode);
            }
            //doc nesnesini dosyaya kaydediyoruz.
            doc.Save("Urunler.xml");
            Process.Start("Urunler.xml");
        }
        NORTHWNDEntities ent = new NORTHWNDEntities();

        private void XMLOlusturma_Load(object sender, EventArgs e)
        {

        }
    }
}
