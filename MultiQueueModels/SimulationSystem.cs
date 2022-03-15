using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }

        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }

        public void BuildInterArrTable()
        {
            InterarrivalDistribution[0].CummProbability = InterarrivalDistribution[0].Probability;
            InterarrivalDistribution[0].MinRange = 1;
            InterarrivalDistribution[0].MaxRange = (int)InterarrivalDistribution[0].Probability*100;


            for (int i=1;i< InterarrivalDistribution.Count;i++)
            {
                int prevTime = InterarrivalDistribution[i].Time;
                decimal prevProp = InterarrivalDistribution[i].Probability;
                InterarrivalDistribution[i].CummProbability = InterarrivalDistribution[i - 1].CummProbability + InterarrivalDistribution[i].Probability;
                InterarrivalDistribution[i].MinRange = InterarrivalDistribution[i - 1].MaxRange + 1;
                InterarrivalDistribution[i].MaxRange = (int)InterarrivalDistribution[i].CummProbability * 100;

            }
        }

        public int FindRange(int RandomNumber)
        {   
            for(int i=0;i < InterarrivalDistribution.Count; i++)
            {
                if (RandomNumber >= InterarrivalDistribution[i].MinRange &&
                   RandomNumber <= InterarrivalDistribution[i].MaxRange)
                {
                    return InterarrivalDistribution[i].Time;
                } 
            }
            return 1;
        }
         
        public Boolean isAvailable(int ServerNum,int ArrTime) 
        {
             if (Servers[ServerNum].FinishTime<= ArrTime)
            {
                return true;
            }
            return false;
        }
        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }



        public void BuildSimulationTable()
        {  
            Random random = new Random();
            SimulationTable[0].RandomInterArrival = 0;
            SimulationTable[0].InterArrival = 0;
            SimulationTable[0].ArrivalTime = 0;
            int returnedServer;
            for (int i = 1; i <StoppingNumber; i++)
            {
                SimulationTable[i].CustomerNumber = i;
                SimulationTable[i].RandomInterArrival = random.Next(1, 100);
                SimulationTable[i].InterArrival = FindRange(SimulationTable[i].RandomInterArrival);
                SimulationTable[i].ArrivalTime = SimulationTable[i - 1].ArrivalTime + SimulationTable[i].InterArrival;
                SimulationTable[i].RandomService = random.Next(1, 100);    
                
                if(SelectionMethod.Equals(Enums.SelectionMethod.HighestPriority))
                {
                    returnedServer = priorServer(SimulationTable[i].ArrivalTime);
                    if(returnedServer != -1)
                    {
                        SimulationTable[i].AssignedServer = Servers[returnedServer];
                    }

                }
            }


        }

        public int priorServer(int arrivalTime)
        {
            for(int j = 0; j < Servers.Count; j++)
            {
                if(isAvailable(j, arrivalTime))
                {
                    return j;
                }
            }

            return -1;
        }
    }
}




