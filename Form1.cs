using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        public ListViewItem li;
        public FileInfo filesize;
        public string[] filename;
        public string[] fileadress;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) //파일불러오기
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.SafeFileNames;
            fileadress = openFileDialog1.FileNames;

            for (int i = 0; i < filename.Length; i++)
            {
                li = new ListViewItem((i + 1).ToString());   //순서
                li.SubItems.Add(filename[i].Split('.')[0]);             //원래이름
                li.SubItems.Add("");                                    //바뀐이름
                li.SubItems.Add(fileadress[i].Replace("\\" + filename[i], ""));                         //파일위치
                li.SubItems.Add(filename[i].Split('.')[1].ToUpper());   //확장자

                filesize = new FileInfo(fileadress[i]);
                li.SubItems.Add(((filesize.Length / 1024) + 1).ToString() + "KB"); //파일크기
                listView1.Items.Add(li);
            }

            openFileDialog1.Reset();
            openFileDialog1.Multiselect = true;
        }

        private void button2_Click(object sender, EventArgs e) //이름지우기
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[2].Text = "";
            }
        }

        private void button9_Click(object sender, EventArgs e) //목록지우기
        {
            listView1.Items.Clear();
            li.SubItems.Clear();
            openFileDialog1.Reset();
            openFileDialog1.Multiselect = true;
        }

        private void button3_Click(object sender, EventArgs e) //이름붙이기
        {
            name nameform = new name();
            nameform.ShowDialog();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[2].Text = nameform.name_send;
            }
        }

        private void 파일불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button8_Click(sender,e);
        } //파일불러오기 단축키

        private void 실제파일로번경ToolStripMenuItem_Click(object sender, EventArgs e)  //실제파일로변경 단축키
        {

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)  //종료 단축키
        {
            this.Dispose();
            this.Close();
        }
    }
}
