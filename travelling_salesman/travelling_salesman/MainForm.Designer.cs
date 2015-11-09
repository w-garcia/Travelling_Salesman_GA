namespace travelling_salesman
{
    partial class MainForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainControl1 = new travelling_salesman.MainControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.multipleControl1 = new travelling_salesman.MultipleControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mainControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Run";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mainControl1
            // 
            this.mainControl1.Location = new System.Drawing.Point(6, 6);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(622, 378);
            this.mainControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.multipleControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multiple Runs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // multipleControl1
            // 
            this.multipleControl1.Location = new System.Drawing.Point(6, 16);
            this.multipleControl1.Name = "multipleControl1";
            this.multipleControl1.Size = new System.Drawing.Size(622, 378);
            this.multipleControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(684, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "CAP4630 Garcia Washington HW2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MainControl mainControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private MultipleControl multipleControl1;


    }
}

