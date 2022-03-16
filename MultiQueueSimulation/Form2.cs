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
            simulationSystem.BuildSimulationTable();
            dataGridView2.ColumnCount = 10;
            dataGridView2.Columns[0].Name = "Customer Number";
            dataGridView2.Columns[1].Name = "Random arrival time";
            dataGridView2.Columns[2].Name = "Interarrival time";
            dataGridView2.Columns[3].Name = "Arrival Time";
            dataGridView2.Columns[4].Name = "Random Service time";
            dataGridView2.Columns[5].Name = "Assigned Server/Index";
            dataGridView2.Columns[6].Name = "Server Service time";
            dataGridView2.Columns[7].Name = "Server Service Start time";
            dataGridView2.Columns[8].Name = "Server Service End time";
            dataGridView2.Columns[9].Name = "Time in Queue";

            for (int i = 0; i < simulationSystem.SimulationTable.Count; i++)
            {
                string[] row = new string[] { simulationSystem.SimulationTable[i].CustomerNumber.ToString(),
                                                       simulationSystem.SimulationTable[i].RandomInterArrival.ToString(),
                                                       simulationSystem.SimulationTable[i].InterArrival.ToString(),
                                                       simulationSystem.SimulationTable[i].ArrivalTime.ToString(),
                                                       simulationSystem.SimulationTable[i].RandomService.ToString(),
                                                       simulationSystem.SimulationTable[i].AssignedServer.ID.ToString(),
                                                       simulationSystem.SimulationTable[i].ServiceTime.ToString(),
                                                       simulationSystem.SimulationTable[i].StartTime.ToString(),
                                                       simulationSystem.SimulationTable[i].EndTime.ToString(),
                                                       simulationSystem.SimulationTable[i].TimeInQueue.ToString()};
                dataGridView2.Rows.Add(row);


            }
        }
    }
}
