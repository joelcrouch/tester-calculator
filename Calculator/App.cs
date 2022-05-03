using System;
using Serilog;

namespace Calculator
{
    public class App
    {
        private readonly ICalculatorWorker _worker;
        private readonly ILogger _logger;

        public App(ICalculatorWorker worker)
        {
            _worker = worker;
            _logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        }

        public void Run()
        {
            _logger.Information($"Using ICalculatorWorker of type: {_worker.GetType().Name}");
            var calculator = new Calculator(_worker);

            Console.WriteLine(calculator.Add(12, 12));
            Console.WriteLine(calculator.Subtract(12, 12));
            Console.WriteLine(calculator.Multiply(12, 12));
            Console.WriteLine(calculator.Divide(12, 12));

            Console.WriteLine(calculator.Add('a', 'A'));
        }
    }
}
