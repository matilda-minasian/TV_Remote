using System;

namespace CS586Project
{
    public class TVStatusDisplay : iTVObserver
    {
        public void Update(iTV tv)
        {
            Console.WriteLine("\n--- TV Status Update ---");
            tv.currentStatus();
            Console.WriteLine("------------------------\n");
        }
    }
}