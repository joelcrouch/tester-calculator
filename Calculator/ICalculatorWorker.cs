namespace Calculator
{
    public interface ICalculatorWorker
    {
        int AddIt(int first, int second);

        int SubtractIt(int first, int second);

        int MultiplyIt(int first, int second);

        int DivideIt(int first, int second);

        int ModIt(int first, int second);

        int FooIt(string bar);
    }
}
