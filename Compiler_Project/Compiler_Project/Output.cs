using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Compiler_Project
{
    public partial class Output : Form
    {
        
        public void AddRow(String lineNum, String Lexeme, String ReturnToken,String LexNumLine,String Match)
        {
            dataGridView1.Rows.Add(lineNum, Lexeme, ReturnToken, LexNumLine, Match);
        }

        public Output()
        {
            
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }
    }
}
