namespace Chapter6_Program3
{ 
    class Worker : Bee
    {
        public string CurrentJob { get; private set; }
        
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobs, double weight) : base(weight)
        {
            jobsICanDo = jobs;
            CurrentJob = string.Empty;
        }

        public bool DoThisJob(string job, int shifts)
        {
            if (!string.IsNullOrEmpty(CurrentJob))
            {
                return false;
            }

            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == job)
                {
                    CurrentJob = job;
                    shiftsToWork = shifts;
                    shiftsWorked = 0;
                    return true;
                }
            }

            return false;
        }

        public bool DidYouFinish()
        {
            if (!string.IsNullOrEmpty(CurrentJob))
            {
                return false;
            }
            
            shiftsWorked++;

            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                CurrentJob = string.Empty;
                return true;
            }

            return false;
        }

        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate() + shiftsWorked * 0.65d;
        }
    }
}
