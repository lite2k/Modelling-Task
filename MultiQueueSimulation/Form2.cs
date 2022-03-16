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
    public partial class Form2 : Form
    {
        SimulationSystem simulationSystem;
        public Form2(SimulationSystem simulationSystem)
        {
            InitializeComponent();
            this.simulationSystem = simulationSystem;
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            simulationSystem.BuildInterArrTable();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Interarrival Time";
            dataGridView1.Columns[1].Name = "Probability";
            dataGridView1.Columns[2].Name = "Cummulative probability";
            dataGridView1.Columns[3].Name = "Min Range";
            dataGridView1.Columns[4].Name = "Max Range";

            for (int i = 0; i < simulationSystem.InterarrivalDistribution.Count; i++)
            {
                string[] row = new string[] { simulationSystem.InterarrivalDistribution[i].Time.ToString(),
                                                  simulationSystem.InterarrivalDistribution[i].Probability.ToString(),
                                                  simulationSystem.InterarrivalDistribution[i].CummProbability.ToString(),
                                                  simulationSystem.InterarrivalDistribution[i].MinRange.ToString(),
                                                  simulationSystem.InterarrivalDistribution[i].MaxRange.ToString()};
                dataGridView1.Rows.Add(row);
            }

            // dataGridView2.ColumnCount = 6;
            // dataGridView2.Columns[0].Name = "Server Index";
            // dataGridView2.Columns[1].Name = "Service Time";
            // dataGridView2.Columns[2].Name = "Probability";
            // dataGridView2.Columns[3].Name = "Cummulative probability";
            // dataGridView2.Columns[4].Name = "Min Range";
            // dataGridView2.Columns[5].Name = "Max Range";

            // for (int i = 0; i < simulationSystem.Servers.Count; i++)
            // {
            //     for (int j = 0; j < simulationSystem.Servers[i].TimeDistribution.Count; j++)
            //     {
            //         string[] row = new string[] { simulationSystem.Servers[i].ID.ToString(),
            //                                           simulationSystem.Servers[i].TimeDistribution[j].Time.ToString(),
            //                                           simulationSystem.Servers[i].TimeDistribution[j].Probability.ToString(),
            //                                           simulationSystem.Servers[i].TimeDistribution[j].CummProbability.ToString(),
            //                                           simulationSystem.Servers[i].TimeDistribution[j].MinRange.ToString(),
            //                                           simulationSystem.Servers[i].TimeDistribution[j].MaxRange.ToString()}; 
            //         dataGridView2.Rows.Add(row);
        }

    }
}
