namespace heheheheh
{
    partial class Lesson2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTtr2001 = new System.Windows.Forms.TabPage();
            this.tabPrc2001 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTtr2001);
            this.tabControl1.Controls.Add(this.tabPrc2001);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTtr2001
            // 
            this.tabTtr2001.BackColor = System.Drawing.Color.Black;
            this.tabTtr2001.Location = new System.Drawing.Point(4, 22);
            this.tabTtr2001.Name = "tabTtr2001";
            this.tabTtr2001.Padding = new System.Windows.Forms.Padding(3);
            this.tabTtr2001.Size = new System.Drawing.Size(795, 427);
            this.tabTtr2001.TabIndex = 0;
            this.tabTtr2001.Text = "Tutorial";
            // 
            // tabPrc2001
            // 
            this.tabPrc2001.Location = new System.Drawing.Point(4, 22);
            this.tabPrc2001.Name = "tabPrc2001";
            this.tabPrc2001.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrc2001.Size = new System.Drawing.Size(795, 427);
            this.tabPrc2001.TabIndex = 1;
            this.tabPrc2001.Text = "Practice";
            this.tabPrc2001.UseVisualStyleBackColor = true;
            // 
            // Lesson2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Lesson2";
            this.Text = "Lesson 2";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTtr2001;
        private System.Windows.Forms.TabPage tabPrc2001;
    }
}