namespace Chapter6_Program3
{
    interface IStingPatrol : IWorker
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}
