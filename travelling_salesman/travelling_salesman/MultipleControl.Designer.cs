namespace travelling_salesman
{
    partial class MultipleControl
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
            this._progressBarMult = new System.Windows.Forms.ProgressBar();
            this._btnGoMult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._nudNumRuns = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._nudNumGensPerRun = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnSaveLatestData = new System.Windows.Forms.Button();
            this._lblRunsSoFar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lblWorkResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._backgroundWorkerMult = new System.ComponentModel.BackgroundWorker();
            this._lblRunsComplete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._nudNumRuns)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNumGensPerRun)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _progressBarMult
            // 
            this._progressBarMult.Location = new System.Drawing.Point(27, 323);
            this._progressBarMult.Name = "_progressBarMult";
            this._progressBarMult.Size = new System.Drawing.Size(576, 32);
            this._progressBarMult.TabIndex = 0;
            // 
            // _btnGoMult
            // 
            this._btnGoMult.Location = new System.Drawing.Point(235, 90);
            this._btnGoMult.Name = "_btnGoMult";
            this._btnGoMult.Size = new System.Drawing.Size(107, 21);
            this._btnGoMult.TabIndex = 1;
            this._btnGoMult.Text = "Go";
            this._btnGoMult.UseVisualStyleBackColor = true;
            this._btnGoMult.Click += new System.EventHandler(this.OnClickGo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "# Runs: ";
            // 
            // _nudNumRuns
            // 
            this._nudNumRuns.Location = new System.Drawing.Point(193, 21);
            this._nudNumRuns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudNumRuns.Name = "_nudNumRuns";
            this._nudNumRuns.Size = new System.Drawing.Size(76, 20);
            this._nudNumRuns.TabIndex = 3;
            this._nudNumRuns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Work: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._nudNumGensPerRun);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._nudNumRuns);
            this.groupBox1.Controls.Add(this._btnGoMult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // _nudNumGensPerRun
            // 
            this._nudNumGensPerRun.Location = new System.Drawing.Point(193, 53);
            this._nudNumGensPerRun.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._nudNumGensPerRun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudNumGensPerRun.Name = "_nudNumGensPerRun";
            this._nudNumGensPerRun.Size = new System.Drawing.Size(76, 20);
            this._nudNumGensPerRun.TabIndex = 5;
            this._nudNumGensPerRun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "# Generations per Run: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnSaveLatestData);
            this.groupBox2.Controls.Add(this._lblRunsSoFar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._lblWorkResult);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(27, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 140);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // _btnSaveLatestData
            // 
            this._btnSaveLatestData.Enabled = false;
            this._btnSaveLatestData.Location = new System.Drawing.Point(463, 35);
            this._btnSaveLatestData.Name = "_btnSaveLatestData";
            this._btnSaveLatestData.Size = new System.Drawing.Size(73, 78);
            this._btnSaveLatestData.TabIndex = 9;
            this._btnSaveLatestData.Text = "Save Latest Data";
            this._btnSaveLatestData.UseVisualStyleBackColor = true;
            this._btnSaveLatestData.Click += new System.EventHandler(this.OnClickSaveData);
            // 
            // _lblRunsSoFar
            // 
            this._lblRunsSoFar.AutoSize = true;
            this._lblRunsSoFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRunsSoFar.Location = new System.Drawing.Point(211, 83);
            this._lblRunsSoFar.Name = "_lblRunsSoFar";
            this._lblRunsSoFar.Size = new System.Drawing.Size(36, 39);
            this._lblRunsSoFar.TabIndex = 8;
            this._lblRunsSoFar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Runs so far: ";
            // 
            // _lblWorkResult
            // 
            this._lblWorkResult.AutoSize = true;
            this._lblWorkResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblWorkResult.Location = new System.Drawing.Point(211, 29);
            this._lblWorkResult.Name = "_lblWorkResult";
            this._lblWorkResult.Size = new System.Drawing.Size(36, 39);
            this._lblWorkResult.TabIndex = 6;
            this._lblWorkResult.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Average # calls to fitness per run)";
            // 
            // _backgroundWorkerMult
            // 
            this._backgroundWorkerMult.WorkerReportsProgress = true;
            this._backgroundWorkerMult.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoWork);
            this._backgroundWorkerMult.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProgressChanged);
            this._backgroundWorkerMult.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnWorkCompleted);
            // 
            // _lblRunsComplete
            // 
            this._lblRunsComplete.AutoSize = true;
            this._lblRunsComplete.Location = new System.Drawing.Point(217, 358);
            this._lblRunsComplete.Name = "_lblRunsComplete";
            this._lblRunsComplete.Size = new System.Drawing.Size(201, 13);
            this._lblRunsComplete.TabIndex = 7;
            this._lblRunsComplete.Text = "Runs complete, wrote file to Output Path.";
            this._lblRunsComplete.Visible = false;
            // 
            // MultipleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblRunsComplete);
            this.Controls.Add(this._progressBarMult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MultipleControl";
            this.Size = new System.Drawing.Size(622, 378);
            ((System.ComponentModel.ISupportInitialize)(this._nudNumRuns)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNumGensPerRun)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar _progressBarMult;
        private System.Windows.Forms.Button _btnGoMult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _nudNumRuns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown _nudNumGensPerRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblWorkResult;
        private System.ComponentModel.BackgroundWorker _backgroundWorkerMult;
        private System.Windows.Forms.Label _lblRunsSoFar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lblRunsComplete;
        private System.Windows.Forms.Button _btnSaveLatestData;
    }
}
