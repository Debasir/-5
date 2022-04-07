using System;

namespace Max5
{
    class Program
    {
        static void Main(string[] args)
        {
            Neurosurgeon neurosurgeon = new Neurosurgeon("ivan", 120, "VSU");
            neurosurgeon.Work();
            Console.WriteLine(neurosurgeon.WorkState);
            neurosurgeon.StopWork();
            Console.WriteLine(neurosurgeon.WorkState);
        }
    }
}
