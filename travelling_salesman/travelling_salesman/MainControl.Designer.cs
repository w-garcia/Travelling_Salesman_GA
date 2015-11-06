namespace travelling_salesman
{
    partial class MainControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnGo = new System.Windows.Forms.Button();
            this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // _btnGo
            // 
            this._btnGo.Location = new System.Drawing.Point(262, 335);
            this._btnGo.Name = "_btnGo";
            this._btnGo.Size = new System.Drawing.Size(107, 29);
            this._btnGo.TabIndex = 0;
            this._btnGo.Text = "Go";
            this._btnGo.UseVisualStyleBackColor = true;
            this._btnGo.Click += new System.EventHandler(this.OnGoClick);
            // 
            // _backgroundWorker
            // 
            this._backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoWork);
            this._backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProgressChanged);
            this._backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnCompleted);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnGo);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(622, 378);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnGo;
        private System.ComponentModel.BackgroundWorker _backgroundWorker;
    }
}
