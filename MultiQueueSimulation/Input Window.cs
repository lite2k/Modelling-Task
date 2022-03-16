using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MultiQueueModels;


namespace MultiQueueSimulation
{
    public partial class InputForm : Form
    {
        SimOutput simOutput;
        SimulationSystem simulationSystem = new SimulationSystem();

        public InputForm()
        {
            InitializeComponent();
            
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            simulationSystem.Servers.Clear();
            simulationSystem.InterarrivalDistribution.Clear();
            int size = -1;
            string text = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                    Console.WriteLine("File not found");
                }
                //Number of servers Ns
                //Stopping number   SN
                //Stoping method    stop
                //selection method  sekection

                text = Regex.Replace(text, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
                text = text.Replace("\r", "");
                string[] elements = text.Split('\n');
                NS.Text = elements[1];
                simulationSystem.NumberOfServers = int.Parse(elements[1]);
                SN.Text = elements[3];
                simulationSystem.StoppingNumber = int.Parse(elements[3]);
                string stop = elements[5];
                string selection =  elements[7];

                if (selection == "1")
                {
                    HP_radioButton.Checked = true;
                    Random_radioButton.Checked = false;
                    simulationSystem.SelectionMethod = Enums.SelectionMethod.HighestPriority;
                }
                else
                {
                    Random_radioButton.Checked = true;
                    HP_radioButton.Checked = false;
                    simulationSystem.SelectionMethod = Enums.SelectionMethod.Random;
                }

                if (stop == "1")
                {
                    Number_radioButton.Checked = true;
                    EndTime_radioButton.Checked = false;
                    simulationSystem.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
                }
                else
                {
                    Number_radioButton.Checked = true;
                    EndTime_radioButton.Checked = false;
                    simulationSystem.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
                }

                //Interarrival Time data extraction
                int index = 9;
                for (; !elements[index].Contains("Service"); index++)
                {
                    string[] line = elements[index].Split(',');
                    TimeDistribution t = new TimeDistribution();
                    t.Time = int.Parse(line[0]);
                    t.Probability = decimal.Parse(line[1]);
                    simulationSystem.InterarrivalDistribution.Add(t);
                }
                //server data extraction
                int serverIndex=1;
                while (index < elements.Length)
                {
                    
                    Server server = new Server();
                    for (index ++; index < elements.Length; index++)
                    {
                        if (elements[index].Contains("Service"))
                            break;

                        string[] line = elements[index].Split(',');
                        server.ID = serverIndex;
                        TimeDistribution t = new TimeDistribution();
                        t.Time = int.Parse(line[0]);
                        t.Probability = decimal.Parse(line[1]);
                        server.TimeDistribution.Add(t);
                    }
                        serverIndex++;
                        simulationSystem.Servers.Add(server);
                }

                //load data into Interarrival grid
                InterarrivalGrid.ColumnCount = 2;
                InterarrivalGrid.Columns[0].Name = "Interarrival Time";
                InterarrivalGrid.Columns[1].Name = "Probability";
                for (int i = 0; i < simulationSystem.InterarrivalDistribution.Count; i++)
                {
                        string[] row = new string[] { simulationSystem.InterarrivalDistribution[i].Time.ToString(),
                                                      simulationSystem.InterarrivalDistribution[i].Probability.ToString()};
                        InterarrivalGrid.Rows.Add(row);
                }

                //Load data into Server Grid
                ServerGrid.ColumnCount = 3;
                ServerGrid.Columns[0].Name = "Server Index";
                ServerGrid.Columns[1].Name = "Service Time";
                ServerGrid.Columns[2].Name = "Probability";
                for (int i = 0;i<simulationSystem.Servers.Count;i++)
                {
                    for (int j = 0; j < simulationSystem.Servers[i].TimeDistribution.Count; j++)
                    {
                        string[] row = new string[] { simulationSystem.Servers[i].ID.ToString(),
                                                      simulationSystem.Servers[i].TimeDistribution[j].Time.ToString(),
                                                      simulationSystem.Servers[i].TimeDistribution[j].Probability.ToString()};
                        ServerGrid.Rows.Add(row);
                    }
                }
            }
            

        }

        private void Out_button_Click(object sender, EventArgs e)
        {
            simOutput = new SimOutput(simulationSystem);
            simOutput.Show();
            Hide();
        }

    }
}
