using Datastruktur;
using IPriorityQueue;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PriorityQueueTester.TestPriorityQueue(() => new MyPriorityQueue<int>(), () => new MyPriorityQueue<string>());
            
        }
    }
}
