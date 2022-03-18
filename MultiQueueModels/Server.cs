using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
        }

        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; }
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;
        public int TotalNumberOfCustomers {get;set;}

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }


        public void BuildServerTable()
        {
            TimeDistribution[0].CummProbability = TimeDistribution[0].Probability;
            TimeDistribution[0].MinRange = 1;
            TimeDistribution[0].MaxRange = (int)(TimeDistribution[0].Probability * 100);


            for (int i = 1; i < TimeDistribution.Count; i++)
            {
                int prevTime = TimeDistribution[i].Time;
                decimal prevProp = TimeDistribution[i].Probability;
                TimeDistribution[i].CummProbability = TimeDistribution[i - 1].CummProbability + TimeDistribution[i].Probability;
                TimeDistribution[i].MinRange = TimeDistribution[i - 1].MaxRange + 1;
                TimeDistribution[i].MaxRange = (int)(TimeDistribution[i].CummProbability * 100);

            }
        }

        public int FindRange(int RandomNumber)
        {
            for (int i = 0; i < TimeDistribution.Count; i++)
            {
                if (RandomNumber >= TimeDistribution[i].MinRange &&
                   RandomNumber <= TimeDistribution[i].MaxRange)
                {
                    return TimeDistribution[i].Time;
                }
            }
            return 1;
        }
    }
}
