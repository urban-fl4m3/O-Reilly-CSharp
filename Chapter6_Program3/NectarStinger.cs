namespace Chapter6_Program3
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public int Nectar { get; set; }

        public NectarStinger(string[] jobs, double weight) : base(jobs, weight)
        {

        }

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int length)
        {
            return 0;
        }

        public void FindFlowers()
        {

        }

        public void GatherNectar()
        {

        }
        
        public void ReturnToHive()
        {

        }
    }
}
