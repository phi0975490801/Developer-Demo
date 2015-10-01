using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Gold
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XmlUrlResolver resolver = new XmlUrlResolver();
            Uri myUri = new Uri("http://dgcsc.org/goldprices.xml");
            Stream s = (Stream)resolver.GetEntity(myUri, null, typeof(Stream));
            // Construct a reader using the Stream object.
            XmlTextReader xmlTextReader = new XmlTextReader(s);

            XmlDataDocument xdoc1 = new XmlDataDocument();
            xdoc1.DataSet.ReadXml(xmlTextReader, XmlReadMode.Auto);

            DataSet ds = xdoc1.DataSet;
            //DataTable dt = ds;
            dataGridView1.DataSource = ds.Tables[1];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
