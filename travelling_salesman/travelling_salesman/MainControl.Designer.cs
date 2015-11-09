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
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._nudGenerations = new System.Windows.Forms.NumericUpDown();
            this._lblBestDistance = new System.Windows.Forms.Label();
            this._lblDistanceDisplay = new System.Windows.Forms.Label();
            this._lblOldDistance = new System.Windows.Forms.Label();
            this._lblDisplayInitial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._nudGenerations)).BeginInit();
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
            this._backgroundWorker.WorkerReportsProgress = true;
            this._backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoWork);
            this._backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProgressChanged);
            this._backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnCompleted);
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(23, 276);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(580, 23);
            this._progressBar.TabIndex = 1;
            // 
            // _nudGenerations
            // 
            this._nudGenerations.Location = new System.Drawing.Point(319, 237);
            this._nudGenerations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._nudGenerations.Name = "_nudGenerations";
            this._nudGenerations.Size = new System.Drawing.Size(91, 20);
            this._nudGenerations.TabIndex = 2;
            this._nudGenerations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _lblBestDistance
            // 
            this._lblBestDistance.AutoSize = true;
            this._lblBestDistance.Location = new System.Drawing.Point(269, 126);
            this._lblBestDistance.Name = "_lblBestDistance";
            this._lblBestDistance.Size = new System.Drawing.Size(118, 13);
            this._lblBestDistance.TabIndex = 3;
            this._lblBestDistance.Text = "Best Evolved Distance:";
            // 
            // _lblDistanceDisplay
            // 
            this._lblDistanceDisplay.AutoSize = true;
            this._lblDistanceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDistanceDisplay.Location = new System.Drawing.Point(27, 159);
            this._lblDistanceDisplay.Name = "_lblDistanceDisplay";
            this._lblDistanceDisplay.Size = new System.Drawing.Size(36, 39);
            this._lblDistanceDisplay.TabIndex = 4;
            this._lblDistanceDisplay.Text = "0";
            this._lblDistanceDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _lblOldDistance
            // 
            this._lblOldDistance.AutoSize = true;
            this._lblOldDistance.Location = new System.Drawing.Point(269, 17);
            this._lblOldDistance.Name = "_lblOldDistance";
            this._lblOldDistance.Size = new System.Drawing.Size(103, 13);
            this._lblOldDistance.TabIndex = 5;
            this._lblOldDistance.Text = "Initial Best Distance:";
            // 
            // _lblDisplayInitial
            // 
            this._lblDisplayInitial.AutoSize = true;
            this._lblDisplayInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDisplayInitial.Location = new System.Drawing.Point(27, 48);
            this._lblDisplayInitial.Name = "_lblDisplayInitial";
            this._lblDisplayInitial.Size = new System.Drawing.Size(36, 39);
            this._lblDisplayInitial.TabIndex = 6;
            this._lblDisplayInitial.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "# Generations: ";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblDisplayInitial);
            this.Controls.Add(this._lblOldDistance);
            this.Controls.Add(this._lblDistanceDisplay);
            this.Controls.Add(this._lblBestDistance);
            this.Controls.Add(this._nudGenerations);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._btnGo);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(622, 378);
            ((System.ComponentModel.ISupportInitialize)(this._nudGenerations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnGo;
        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.NumericUpDown _nudGenerations;
        private System.Windows.Forms.Label _lblBestDistance;
        private System.Windows.Forms.Label _lblDistanceDisplay;
        private System.Windows.Forms.Label _lblOldDistance;
        private System.Windows.Forms.Label _lblDisplayInitial;
        private System.Windows.Forms.Label label1;
    }
}
