
namespace Compiler_Project
{
    partial class Output
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LineNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexemenumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matchability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNO,
            this.Lexeme,
            this.ReturnToken,
            this.Lexemenumb,
            this.Matchability});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(815, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LineNO
            // 
            this.LineNO.HeaderText = "Line NO";
            this.LineNO.MinimumWidth = 8;
            this.LineNO.Name = "LineNO";
            this.LineNO.ReadOnly = true;
            this.LineNO.Width = 150;
            // 
            // Lexeme
            // 
            this.Lexeme.HeaderText = "Lexeme";
            this.Lexeme.MinimumWidth = 8;
            this.Lexeme.Name = "Lexeme";
            this.Lexeme.ReadOnly = true;
            this.Lexeme.Width = 150;
            // 
            // ReturnToken
            // 
            this.ReturnToken.HeaderText = "Return Token";
            this.ReturnToken.MinimumWidth = 8;
            this.ReturnToken.Name = "ReturnToken";
            this.ReturnToken.ReadOnly = true;
            this.ReturnToken.Width = 150;
            // 
            // Lexemenumb
            // 
            this.Lexemenumb.HeaderText = "Lexeme No in Line";
            this.Lexemenumb.MinimumWidth = 8;
            this.Lexemenumb.Name = "Lexemenumb";
            this.Lexemenumb.ReadOnly = true;
            this.Lexemenumb.Width = 150;
            // 
            // Matchability
            // 
            this.Matchability.HeaderText = "Matchability";
            this.Matchability.MinimumWidth = 8;
            this.Matchability.Name = "Matchability";
            this.Matchability.ReadOnly = true;
            this.Matchability.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total No of errors";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 536);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 31);
            this.textBox1.TabIndex = 2;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 613);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Output";
            this.Text = "Output";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexemenumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matchability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}