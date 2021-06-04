
namespace Compiler_Project
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Editor = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.Location = new System.Drawing.Point(221, 134);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(297, 55);
            this.Editor.TabIndex = 0;
            this.Editor.Text = "Editor";
            this.Editor.UseVisualStyleBackColor = true;
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(221, 233);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(297, 55);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 478);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Editor);
            this.Name = "Start";
            this.Text = "Compiler Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Editor;
        private System.Windows.Forms.Button Browse;
    }
}

