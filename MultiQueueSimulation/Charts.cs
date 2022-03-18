using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    public partial class Charts : Form
    {
        SimulationSystem simulationSystem;
        Charts chart;
        Metrics metrics;
        public Charts(SimulationSystem simulationSystem)
        {
            InitializeComponent();
            this.simulationSystem = simulationSystem;

        }
        private void Charts_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //perServerChart.Series["Performance"].Points.AddXY();
        }

        private void metricsButton_Click(object sender, EventArgs e)
        {
            metrics = new Metrics(simulationSystem);
            metrics.Show();
            Hide();
        }

        private void nextServerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
