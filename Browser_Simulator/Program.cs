namespace Browser_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringStack stack = new StringStack();
            Simulator simulator = new Simulator();
            simulator.Run(stack);
        }
    }
}