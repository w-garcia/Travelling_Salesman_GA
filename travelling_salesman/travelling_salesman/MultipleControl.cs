using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace travelling_salesman
{
    public partial class MultipleControl : UserControl
    {
        string _filePath = AppDomain.CurrentDomain.BaseDirectory;
        List<double> _runResults = new List<double>();
        GeneticAlgorithm _classGA;

        int _generationsSoFar = 0;
        int _runsSoFar = 0;
        double _totalWorkDone = 0;

        public MultipleControl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OnClickGo(object sender, EventArgs e)
        {
            _lblRunsComplete.Visible = false;
            DisableControls();

            _progressBarMult.Value = 0;
            _runsSoFar++;
            _classGA = new GeneticAlgorithm();
            _backgroundWorkerMult.RunWorkerAsync();
        }

        private void DisableControls()
        {
            _btnGoMult.Enabled = false;
            _nudNumRuns.Enabled = false;
            _nudNumGensPerRun.Enabled = false;
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            _classGA.Population.RunGenerations(Convert.ToInt32(_nudNumGensPerRun.Value), _backgroundWorkerMult);

        }

        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _progressBarMult.Value = e.ProgressPercentage;
        }

        private void OnWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _totalWorkDone += _classGA.Population.WorkDone;
            _lblWorkResult.Text = Convert.ToString((_totalWorkDone) / _runsSoFar);
            _lblRunsSoFar.Text = Convert.ToString(_runsSoFar);


            if (_runsSoFar < _nudNumRuns.Value && _classGA.Population.GenerationsSoFar == _nudNumGensPerRun.Value)
            {
                _runResults.Add(_classGA.Population.BestSolution.Fitness);

                _progressBarMult.Value = 0;
                _runsSoFar++;
                _classGA = new GeneticAlgorithm();
                _backgroundWorkerMult.RunWorkerAsync();
            }
            else if (_runsSoFar == _nudNumRuns.Value)
            {
                _runResults.Add(_classGA.Population.BestSolution.Fitness);
                _progressBarMult.Value = 100;

                _runsSoFar = 0;
                _totalWorkDone = 0;

                EnableControls();
                WriteResults();

            }
        }

        private void WriteResults()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Delimited File | .csv";

            sfd.InitialDirectory = _filePath;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _filePath = sfd.FileName;
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    for (int i = 0; i < _runResults.Count; i++)
                    {
                        sw.WriteLine(_runResults[i] + ",");
                    }
                }

                _lblRunsComplete.Visible = true;

            }
        }

        private void EnableControls()
        {
            _btnGoMult.Enabled = true;
            _nudNumRuns.Enabled = true;
            _nudNumGensPerRun.Enabled = true;
        }


    }
}
