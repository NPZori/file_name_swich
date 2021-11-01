using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class name : Form
    {
        public string name_send = "";

        public name()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //확인
        {
            name_send = textBox1.Text;
            this.Close();
        }
    }
}
