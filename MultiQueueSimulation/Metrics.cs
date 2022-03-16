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
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Metrics : Form
    {
        SimOutput SimOutput;
        SimulationSystem simulationSystem;
        public Metrics(SimulationSystem simulationSystem)
        {
            InitializeComponent();
            this.simulationSystem = simulationSystem;
        }
        private void Metrics_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            simulationSystem.CalculatePerformaneMeasures();

            averageText.Text = simulationSystem.PerformanceMeasures.AverageWaitingTime.ToString();
            waitText.Text = simulationSystem.PerformanceMeasures.WaitingProbability.ToString();
            maxQText.Text = simulationSystem.PerformanceMeasures.MaxQueueLength.ToString();

            simulationSystem.CalculatePerServerPerformance();

            perServerGrid.ColumnCount = 4;
            perServerGrid.Columns[0].Name = "Server ID";
            perServerGrid.Columns[1].Name = "Idle Probability";
            perServerGrid.Columns[2].Name = "Average Service Time";
            perServerGrid.Columns[3].Name = "Utilization";

            for(int i = 0;i<simulationSystem.Servers.Count;i++)
            {
                string[] row = new string[] {simulationSystem.Servers[i].ID.ToString(),
                                             simulationSystem.Servers[i].IdleProbability.ToString(),
                                             simulationSystem.Servers[i].AverageServiceTime.ToString(),
                                             simulationSystem.Servers[i].Utilization.ToString()};
                perServerGrid.Rows.Add(row);
            }
            //SimulationSystem system = new SimulationSystem();
            string result = TestingManager.Test(simulationSystem, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
        }

        private void SimOutButton_Click(object sender, EventArgs e)
        {
            SimOutput = new SimOutput(simulationSystem);
            SimOutput.Show();
            Hide();
        }

    }
}
