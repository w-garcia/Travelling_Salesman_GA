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
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            GA.Population.RunGenerations(100, _backgroundWorker);
        }

        private void OnCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _btnGo.Enabled = true;
        }

        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
    }
}
