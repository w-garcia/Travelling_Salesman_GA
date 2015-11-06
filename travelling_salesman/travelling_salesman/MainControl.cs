using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelling_salesman
{
    public partial class MainControl : UserControl
    {
        GeneticAlgorithm GA = new GeneticAlgorithm();

        public MainControl()
        {
            InitializeComponent();
        }

        private void OnGoClick(object sender, EventArgs e)
        {
            _btnGo.Enabled = false;
            _backgroundWorker.RunWorkerAsync();
            _progressBar.Value = 0;
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            GA.Population.RunGenerations(Convert.ToInt32(_nudGenerations.Value), _backgroundWorker);
        }

        private void OnCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _btnGo.Enabled = true;
            _progressBar.Value = 100;
            _lblDistanceDisplay.Text = Convert.ToString(GA.Population.BestSolution.DistanceTravelled);
            _lblDisplayInitial.Text = Convert.ToString(GA.Population.InitialSolution.DistanceTravelled);
        }

        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _progressBar.Value = e.ProgressPercentage;
        }
    }
}
