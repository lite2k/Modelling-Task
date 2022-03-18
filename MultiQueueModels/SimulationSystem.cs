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
            InterarrivalDistribution[0].MaxRange = (int)(InterarrivalDistribution[0].Probability * 100);


            for (int i = 1; i < InterarrivalDistribution.Count; i++)
            {
                int prevTime = InterarrivalDistribution[i].Time;
                decimal prevProp = InterarrivalDistribution[i].Probability;
                InterarrivalDistribution[i].CummProbability = InterarrivalDistribution[i - 1].CummProbability + InterarrivalDistribution[i].Probability;
                InterarrivalDistribution[i].MinRange = InterarrivalDistribution[i - 1].MaxRange + 1;
                InterarrivalDistribution[i].MaxRange = (int)(InterarrivalDistribution[i].CummProbability * 100);

            }
        }




        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }



        public void BuildSimulationTable()
        {
            for (int i = 0; i < Servers.Count; i++)
            {
                Servers[i].BuildServerTable();
            }
            //Cannot index an empty object,
            //object must be intialized first and data must be added before refrence
            SimulationTable = new List<SimulationCase>();
            SimulationCase Scase;
            Random random = new Random();
            int returnedServer;

            setTotalWorkingTime();



            for (int i = 0; i < StoppingNumber; i++)
            {
                Scase = new SimulationCase();
                if (i == 0)
                {

                    Scase.InterArrival = 1;
                    Scase.RandomInterArrival = 1;
                    Scase.ArrivalTime = 0;
                    Scase.CustomerNumber = 1;

                    Scase.RandomService = random.Next(1, 100);
                    SimulationTable.Add(Scase);

                }
                else
                {
                    Scase.RandomInterArrival = random.Next(1, 100);
                    Scase.InterArrival = FindRange(Scase.RandomInterArrival);
                    Scase.ArrivalTime = SimulationTable[i - 1].ArrivalTime + Scase.InterArrival;
                    Scase.CustomerNumber = i + 1;

                    Scase.RandomService = random.Next(1, 100);
                    SimulationTable.Add(Scase);
                }

                //cannot directly index/refrence an empty object from a list


                if (SelectionMethod.Equals(Enums.SelectionMethod.HighestPriority))
                {
                    returnedServer = priorServer(Scase.ArrivalTime);
                    if (returnedServer != -1)
                    {
                        fillServerInfo(i, returnedServer, Scase.ArrivalTime);
                    }
                    else
                    {
                        int queuedServer = findMinFinishTime();
                        fillServerInfo(i, queuedServer, Servers[queuedServer].FinishTime);
                    }
                }
                else if (SelectionMethod.Equals(Enums.SelectionMethod.Random))
                {
                    Random rand = new Random();
                    List<int> uniqueRandoms = new List<int>();
                    while (true)
                    {
                        int randomServer = rand.Next(0, Servers.Count);
                        if (!uniqueRandoms.Contains(randomServer))
                        {
                            if (isAvailable(randomServer, SimulationTable[i].ArrivalTime))
                            {
                                fillServerInfo(i, randomServer, Scase.ArrivalTime);
                                break;
                            }

                            uniqueRandoms.Add(randomServer);
                        }
                        if (uniqueRandoms.Count == Servers.Count)
                        {
                            int queuedServer = findMinFinishTime();
                            fillServerInfo(i, queuedServer, Servers[queuedServer].FinishTime);
                            break;
                        }
                    }
                }
                SimulationTable[i].TimeInQueue =
                    SimulationTable[i].StartTime - SimulationTable[i].ArrivalTime;

            }


        }


        public void setTotalWorkingTime()
        {
            for (int i = 0; i < Servers.Count; i++)
            {
                Servers[i].TotalWorkingTime = 0;
            }
        }
        public void fillServerInfo(int index, int ser, int startTime)
        {
            //Servers[ser].ID = ser;
            SimulationTable[index].AssignedServer = Servers[ser];
            SimulationTable[index].StartTime = startTime;

            SimulationTable[index].ServiceTime =
            SimulationTable[index].AssignedServer.FindRange(SimulationTable[index].RandomService);

            Servers[ser].TotalWorkingTime += SimulationTable[index].ServiceTime;
            Servers[ser].TotalNumberOfCustomers += 1;
            SimulationTable[index].EndTime = SimulationTable[index].StartTime + SimulationTable[index].ServiceTime;
            SimulationTable[index].AssignedServer.FinishTime = SimulationTable[index].EndTime;
            Servers[ser].FinishTime = SimulationTable[index].AssignedServer.FinishTime;
        }
        public int findMinFinishTime()
        {
            int min = 1000000;
            int serverIndex = 0;
            for (int i = 0; i < Servers.Count; i++)
            {
                if (Servers[i].FinishTime < min)
                {
                    min = Servers[i].FinishTime;
                    serverIndex = i;
                }
            }
            return serverIndex;
        }
        public int priorServer(int arrivalTime)
        {
            for (int j = 0; j < Servers.Count; j++)
            {
                if (isAvailable(j, arrivalTime))
                {
                    return j;
                }
            }

            return -1;
        }
        public int FindRange(int RandomNumber)
        {
            for (int i = 0; i < InterarrivalDistribution.Count; i++)
            {
                if (RandomNumber >= InterarrivalDistribution[i].MinRange &&
                   RandomNumber <= InterarrivalDistribution[i].MaxRange)
                {
                    return InterarrivalDistribution[i].Time;
                }
            }
            return 1;
        }
        public bool isAvailable(int ServerNum, int ArrivalTime)
        {
            if (Servers[ServerNum].FinishTime <= ArrivalTime)
            {
                return true;
            }
            return false;
        }

        public void CalculatePerformaneMeasures()
        {
            decimal waitedTimeSum = 0;
            decimal waitedCustomers = 0;
            int maxWait = 0;
            int count = 1;
            //int TimeToWait = SimulationTable[0].ArrivalTime + SimulationTable[0].TimeInQueue; ;

            for (int i = 0; i < SimulationTable.Count; i++)
            {
                waitedTimeSum += SimulationTable[i].TimeInQueue;

                if (SimulationTable[i].TimeInQueue != 0)
                {
                    waitedCustomers += 1;
                    int TimeToWait = SimulationTable[i].ArrivalTime + SimulationTable[i].TimeInQueue; 
                    for (int j=i+1;j< SimulationTable.Count;j++)
                    {
                        if(SimulationTable[j].ArrivalTime < TimeToWait)
                        {
                            count++;
                        }
                        else
                        {
                            if (maxWait< count)
                            {
                                maxWait = count;
                            }
                            count = 1;
                            break;
                        }
                    }
                    
                }




            }
            PerformanceMeasures.AverageWaitingTime = (waitedTimeSum / SimulationTable.Count);
            PerformanceMeasures.WaitingProbability = (waitedCustomers / SimulationTable.Count);
            PerformanceMeasures.MaxQueueLength = maxWait;

        }

        public void CalculatePerServerPerformance()
        {
            decimal maxFinishTime = 0;
            decimal totalIdleTime = 0;
            for (int i = 0; i < Servers.Count; i++)
            {
                if (Servers[i].FinishTime > maxFinishTime)
                {
                    maxFinishTime = Servers[i].FinishTime;
                }

            }

            for (int j = 0; j < Servers.Count; j++)
            {
                totalIdleTime = maxFinishTime - Servers[j].TotalWorkingTime;
                Servers[j].IdleProbability = totalIdleTime / maxFinishTime;
                if (Servers[j].TotalNumberOfCustomers == 0)
                {
                    Servers[j].AverageServiceTime = 0;
                }
                else
                {
                    Servers[j].AverageServiceTime = (decimal)((decimal)Servers[j].TotalWorkingTime / (decimal)Servers[j].TotalNumberOfCustomers);
                }
                //Not sure
                Servers[j].Utilization = Servers[j].TotalWorkingTime / maxFinishTime;
            }



        }
    }
}




