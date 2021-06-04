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
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("test.txt");
            txt.Write(textBox1.Text);
            txt.Close();

        }

        private void ScanButton_Click(object sender, EventArgs e)
        {

            Scanner s = new Scanner();
            s.ScanToken("test");

           
        }
    }
}
