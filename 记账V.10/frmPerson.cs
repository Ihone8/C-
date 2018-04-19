using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
namespace 记账V._10
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
            GetInsertItems();
        }
        //设置当前日期时间      
        static DateTime start = new DateTime(DateTime.Now.Year,  DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        static DateTime end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);     
        private void frmPerson_Load(object sender, EventArgs e)
        {

            try
            {
                //读取该程序中是否有 Person.xml文件
                XElement Find = XElement.Load("Person.xml");
                //读取XML数据 并且进行当前日期筛选，绑定到数据控件上
                ShowPerosnDothins(start, end);
            }
            catch (Exception)
            {
                //如果没有该 Person.xml文件 则创建一个新的 Person.xml 文件
                XElement doc = new XElement("Items");
                doc.Save("Person.xml");
            }
            

        }
        /// <summary>
        /// 添加今日所做的事情和所花费的金额方法（）
        /// </summary>
        /// <param name="person">用户实体类</param>
        private void AddXML(Person person)
        {                        
               string ID = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString()+DateTime.Now.Millisecond.ToString();
            XElement doc = XElement.Load("Person.xml");
            doc.Add(new XElement("item",
                             new XElement("ID",ID),
                             new XElement("Dothing",person.Dothings),
                             new XElement("GetDateTime",DateTime.Now),
                             new XElement("Price",person.Price),
                             new XElement("State",0)));
            doc.Save("Person.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDothings.Text))
            {
                MessageBox.Show("请输入今日所做的事情");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("请输入所做事情花费的金额");
                return;
            }
            //实例化一个Person 对象 并对其属性赋值，
            Person person = new Person();
            person.Dothings = txtDothings.Text;
            person.Price = decimal.Parse(textBox2.Text.Trim());
            //调用添加数据方法（）
            AddXML(person);
            //绑定数据
            ShowPerosnDothins(start,end);
            
        }
        /// <summary>
        /// 读取数据 并且进行当前日期筛选，绑定到数据控件上
        /// </summary>
        /// <param name="Start">今日日期的开始时间</param>
        /// <param name="End">今日日期的结束时间am>
        private void ShowPerosnDothins( DateTime Start,DateTime End)
        {
            dgPerson.AutoGenerateColumns = false;
            dgPerson.DataSource = (from P in ReadPersonXML() where P.GetDateTime > Start && P.GetDateTime < End select P).ToList();
            //获取今日所花费的金额
            List<Person> perosn = (from P in ReadPersonXML() where P.GetDateTime > Start && P.GetDateTime < End select P).ToList();
            decimal SumMoney = 0m;
            foreach (var item in perosn)
            {
                SumMoney += item.Price;
            }
            lblSumMoney.Text = "￥" + SumMoney;
        }
        /// <summary>
        /// 读取XML文件下面的数据
        /// </summary>
        /// <returns>一个数据集合</returns>
        private List<Person> ReadPersonXML()
        {
            XmlDocument doc1 = new XmlDocument();
            try
            {
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
            catch (Exception)
            {
                XElement doc = new XElement("Items");
                doc.Save("Person.xml");
            }
            return null;
        }
        /// <summary>
        /// 智能提示项
        /// </summary>
        private void GetInsertItems()
        {
            var source=new AutoCompleteStringCollection();
            //往智能提示中的文字 进行添加
            foreach (var item in ReadPersonXML())
            {
                source.Add(item.Dothings);
            }
            //给该文本框绑定数据源
            txtDothings.AutoCompleteCustomSource = source;
        }

        private void dtPersonSelectTime_ValueChanged(object sender, EventArgs e)
        {
            //获取用户选择时间控件的值，并且设置改天的时间 从0:0:0点 到23:59:59点
            DateTime start = new DateTime(dtPersonSelectTime.Value.Year,  dtPersonSelectTime.Value.Month, dtPersonSelectTime.Value.Day, 0, 0, 0);
            DateTime end = new DateTime(dtPersonSelectTime.Value.Year, dtPersonSelectTime.Value.Month, dtPersonSelectTime.Value.Day, 23, 59, 59);
            //对数据进行时间筛选，并绑定到该控件上
            ShowPerosnDothins(start, end);
        }
       
    }
}
