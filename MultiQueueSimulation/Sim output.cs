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
    public partial class SimOutput : Form
    {
        Metrics metrics;
        InputForm inputForm;
        SimulationSystem simulationSystem;

        public SimOutput(SimulationSystem simulationSystem)
        {
            InitializeComponent();
            this.simulationSystem = simulationSystem;
        }

        private void SimOutput_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            simulationSystem.BuildInterArrTable();

            //Load interarrival table into grid
            interarrivalGrid.ColumnCount = 5;
            interarrivalGrid.Columns[0].Name = "Interarrival Time";
            interarrivalGrid.Columns[1].Name = "Probability";
            interarrivalGrid.Columns[2].Name = "Cummulative probability";
            interarrivalGrid.Columns[3].Name = "Min Range";
            interarrivalGrid.Columns[4].Name = "Max Range";
            for (int i = 0; i < simulationSystem.InterarrivalDistribution.Count; i++)
            {
                string[] row = new string[] { simulationSystem.InterarrivalDistribution[i].Time.ToString(),
                                                  simulationSystem.InterarrivalDistribution[i].Probability.ToString(),
                                                  simulationSystem.InterarrivalDistribution[i].CummProbability.ToString(),
                                                  simulationSystem.InterarrivalDistribution[i].MinRange.ToString(),
                                                  simulationSystem.InterarrivalDistribution[i].MaxRange.ToString()};
                interarrivalGrid.Rows.Add(row);
            }

            simulationSystem.BuildSimulationTable();

            //Load simulation table into grid
            simGrid.ColumnCount = 10;
            simGrid.Columns[0].Name = "Customer Number";
            simGrid.Columns[1].Name = "Random arrival time";
            simGrid.Columns[2].Name = "Interarrival time";
            simGrid.Columns[3].Name = "Arrival Time";
            simGrid.Columns[4].Name = "Random Service time";
            simGrid.Columns[5].Name = "Assigned Server/Index";
            simGrid.Columns[6].Name = "Server Service time";
            simGrid.Columns[7].Name = "Server Service Start time";
            simGrid.Columns[8].Name = "Server Service End time";
            simGrid.Columns[9].Name = "Time in Queue";
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
                simGrid.Rows.Add(row);


            }

            simulationSystem.BuildInterArrTable();

            //load server table into grid
            ServerGrid.ColumnCount = 6;
            ServerGrid.Columns[0].Name = "Server Index";
            ServerGrid.Columns[1].Name = "Interarrival Time";
            ServerGrid.Columns[2].Name = "Probability";
            ServerGrid.Columns[3].Name = "Cummulative probability";
            ServerGrid.Columns[4].Name = "Min Range";
            ServerGrid.Columns[5].Name = "Max Range";
            for (int i = 0; i < simulationSystem.Servers.Count; i++)
            {
                for (int j = 0; j < simulationSystem.Servers[i].TimeDistribution.Count; j++)
                {
                    string[] row = new string[] { simulationSystem.Servers[i].ID.ToString(),
                                                  simulationSystem.Servers[i].TimeDistribution[j].Time.ToString(),
                                                  simulationSystem.Servers[i].TimeDistribution[j].Probability.ToString(),
                                                  simulationSystem.Servers[i].TimeDistribution[j].CummProbability.ToString(),
                                                  simulationSystem.Servers[i].TimeDistribution[j].MinRange.ToString(),
                                                  simulationSystem.Servers[i].TimeDistribution[j].MaxRange.ToString()};
                    ServerGrid.Rows.Add(row);
                }
            }
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            
        }
        private void Performance_Button_Click(object sender, EventArgs e)
        {
            metrics = new Metrics(simulationSystem);
            metrics.Show();
            Hide();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm();
            inputForm.Show();
            Hide();
        }
    }
}
