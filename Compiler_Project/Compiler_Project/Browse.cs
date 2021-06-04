using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Compiler_Project
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFile.ShowDialog();
            path.Text = OpenFile.FileName;
            filename.Text=Path.GetFileName(OpenFile.FileName);
            txtfile.Text = Path.GetExtension(OpenFile.FileName);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Scanner s = new Scanner();
            s.ScanToken(path.Text);

         
        }
    }
}
