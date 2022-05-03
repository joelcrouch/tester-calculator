namespace Calculator
{
    public class Calculator
    {
        private ICalculatorWorker _calculatorWorker;

        // Inject via property
        public ICalculatorWorker Worker
        {
            get { return _calculatorWorker; }
            set { _calculatorWorker = value; }
        }

        public Calculator() :
            this(new CalculatorWorker())
        { }

        // Inject in construtor
        public Calculator(ICalculatorWorker calculatorWorker)
        {
            _calculatorWorker = calculatorWorker;
        }

        // Inject via method
        public void SetWorker(ICalculatorWorker calculatorWorker)
        {
            Worker = calculatorWorker;
        }


        public int Add(int first, int second)
        {
            return _calculatorWorker.AddIt(first, second);
        }

        public int Subtract(int first, int second)
        {
            return _calculatorWorker.SubtractIt(first, second);
        }

        public int Multiply(int first, int second)
        {
            return _calculatorWorker.MultiplyIt(first, second);
        }

        public int Divide(int first, int second)
        {
            return _calculatorWorker.DivideIt(first, second);
        }

        public int Foo(string bar)
        {
            return _calculatorWorker.FooIt(bar);
        }
    }
}
