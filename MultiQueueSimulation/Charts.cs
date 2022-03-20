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
        int ID;
        public Charts(SimulationSystem simulationSystem, int ID)
        {
            InitializeComponent();
            this.simulationSystem = simulationSystem;
            this.ID = ID;

        }
        private void Charts_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            Server server = simulationSystem.Servers[ID - 1];
            server.serverStatus.Clear();
            simulationSystem.AssignServerStatus(ID);
            for (int i = 1; i < server.serverStatus.Count; i++)
            {
                if(server.serverStatus[i])
                    perServerChart.Series["Performance"].Points.AddXY(i,1);
                else
                    perServerChart.Series["Performance"].Points.AddXY(i, 0);
            }
            string title = "Server " + ID.ToString();
            perServerChart.Titles.Add(title);
            if (!server.serverStatus.Contains(true))
                MessageBox.Show("Server was Idle during system lifetime", "Idle Server");

            
        }

        private void metricsButton_Click(object sender, EventArgs e)
        {
            metrics = new Metrics(simulationSystem);
            metrics.Show();
            Hide();
        }

        private void nextServerButton_Click(object sender, EventArgs e)
        {
            try
            {
               Server next = simulationSystem.Servers[ID];
               int nextID = ID+1;
               chart = new Charts(simulationSystem,nextID);
               chart.Show();
               Close();
            }catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You reached the last server", "Error: List index out of Range");
            }
        }
        private void previousServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Server next = simulationSystem.Servers[ID-2];
                int prevID = ID -2;
                chart = new Charts(simulationSystem, prevID);
                chart.Show();
                Close();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You reached the First server", "Error: List index out of Range");
            }
        }
    }
}
