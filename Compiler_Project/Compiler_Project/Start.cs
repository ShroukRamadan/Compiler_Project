using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiler_Project
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Editor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editor f1 = new Editor();
            f1.ShowDialog();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Browse f1 = new Browse();
            f1.ShowDialog();

        }
    }
}
