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
using System.Xml.Serialization;
namespace 记账V._10
{
    public partial class frmTJ : Form
    {
        public frmTJ()
        {
            InitializeComponent();
        }

        private void frmTJ_Load(object sender, EventArgs e)
        {
            
            List<string> Dothings = new List<string>();
            
            foreach (var item in ReadPersonXML())
            {
                Dothings.Add(item.Dothings);
            }
            for (int i = 0; i < Dothings.Count; i++)
            {
                lstDothings.Items.Add(Dothings[i]);
            }
        }
        /// <summary>
        /// 读取XML文件下面的数据
        /// </summary>
        /// <returns>一个数据集合</returns>
        private List<Person> ReadPersonXML()
        {
            System.Xml.XmlDocument doc1 = new XmlDocument();
            doc1.Load("Person.xml");
            XmlNode xn = doc1.SelectSingleNode("Items");
            XmlNodeList xnl = xn.ChildNodes;
            List<Person> items = new List<Person>();
            foreach (XmlNode item in xnl)
            {
                Person model = new Person();
                XmlElement xe = (XmlElement)item;
                XmlNodeList xnl0 = xe.ChildNodes;
                model.ID = xnl0.Item(0).InnerText;
                model.Dothings = xnl0.Item(1).InnerText;
                model.GetDateTime = DateTime.Parse(xnl0.Item(2).InnerText);
                model.Price = decimal.Parse(xnl0.Item(3).InnerText);
                model.State = int.Parse(xnl0.Item(4).InnerText);
                items.Add(model);
            }
            return items;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='6')
            {
               // MessageBox.Show("66666666");
                //return;
            }
            if(txtSR.Text.Length==15)
            {
                MessageBox.Show("只能输入15位");
            }
        }
       
        
    }
}
