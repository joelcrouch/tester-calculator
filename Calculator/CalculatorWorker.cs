using EnsureThat;

namespace Calculator
{
    public class CalculatorWorker : ICalculatorWorker
    {
        public int AddIt(int first, int second)
        {
            return first + second;
        }

        public int SubtractIt(int first, int second)
        {
            return first - second;
        }

        public int MultiplyIt(int first, int second)
        {
            return first * second;
        }

        public int DivideIt(int first, int second)
        {
            Ensure.That(second, nameof(second)).IsNot(0);
            return first / second;
        }

        public int ModIt(int first, int second)
        {
            Ensure.That(second, nameof(second)).IsNot(0);
            return first % second;
        }

        public int FooIt(string bar)
        {
            Ensure.That(bar, nameof(bar)).IsNotNullOrWhiteSpace();
            return bar.Length;
        }
    }
}
