namespace Chapter6_Program3
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers, double weight) : base(weight)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, shifts))
                {
                    return true;
                }
            }

            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = $"Отчёт для смены#{shiftNumber}\r\n";
            double honeyConsumed = HoneyConsumptionRate();

            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyConsumptionRate();

                if (workers[i].DidYouFinish())
                {
                    report += $"Рабочий #{i + 1} закончил работу\r\n";
                }


                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += $"Рабочий #{i+1} не работает\r\n";
                }
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        report += $"Рабочий #{i+1} выполняет '{workers[i].CurrentJob}' ещё {workers[i].ShiftsLeft} " +
                            $"смен\r\n";
                    }
                    else
                    {
                        report += $"Рабочий #{i + 1} закончит '{workers[i].CurrentJob}' после этой смены\r\n";
                    }
                }
            }


            report += $"Total honey consumed for the shift: {honeyConsumed} units";

            return report;
        }
    }
}
