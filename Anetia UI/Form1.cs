using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnetiaApi;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static AnetiaApi.Main Anetia;

        public Form1()
        {
            InitializeComponent();
            Anetia = new AnetiaApi.Main();
            Anetia.InvokeApi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anetia.Execute(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anetia.Inject();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool areweud = Anetia.IsAttached();
            if (areweud)
            {
                MessageBox.Show("we in the mainframe");
            }
            else
            {
                MessageBox.Show("kys");
            }
        }
    }
}
