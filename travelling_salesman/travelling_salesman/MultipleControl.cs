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

        GeneticAlgorithm _bestSolution = new GeneticAlgorithm();

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
            _runResults.Clear();
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
                
                if (_classGA.Population.BestSolution < _bestSolution.Population.BestSolution)
                {
                    _bestSolution = _classGA;
                }

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

        private int CompareValue(indexToDouble x, indexToDouble y)
        {
            return x.order.CompareTo(y.order);
        }

        private void WriteResults()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Delimited File | .csv";

            sfd.InitialDirectory = _filePath;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                _filePath = sfd.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(_filePath))
                    {
                        for (int i = 0; i < _runResults.Count; i++)
                        {
                            sw.WriteLine(_runResults[i] + ",");
                        }
                        sw.WriteLine("Best Solution X and Y: ");

                        List<indexToDouble> sortedList = new List<indexToDouble>();

                        Solution bestSolution = _bestSolution.Population.BestSolution;

                        for (int i = 0; i < bestSolution.Genome.Count; i++)
                        {
                            sortedList.Add(new indexToDouble(i, bestSolution.Genome[i]));
                        }

                        sortedList.Sort(CompareValue);

                        List<City> bestProblem = _bestSolution.Problem.CityMatrix;

                        for (int i = 0; i < bestProblem.Count; i++)
                        {
                            sw.WriteLine(bestProblem[sortedList[i].index].x + "," + bestProblem[sortedList[i].index].y);
                        }

                    }

                    _lblRunsComplete.Visible = true;
                }
                catch (IOException)
                {
                    MessageBox.Show("File is being used by another process, try closing the file and trying again later. ");
                }

            }
        }

        private void EnableControls()
        {
            _btnGoMult.Enabled = true;
            _nudNumRuns.Enabled = true;
            _nudNumGensPerRun.Enabled = true;
            _btnSaveLatestData.Enabled = true;

        }

        private void OnClickSaveData(object sender, EventArgs e)
        {
            WriteResults();
        }


    }
}
