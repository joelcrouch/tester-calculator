using FakeItEasy;
using Xunit;

namespace Calculator
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculator_Add_Success()
        {
            var worker = A.Fake<ICalculatorWorker>();

            // Inject in constructor
            //var calc = new Calculator(worker);

            // Inject via property
            //var calc = new Calculator(new CalculatorWorker());
            //calc.Worker = worker;


            // Inject via method
            var calc = new Calculator(new CalculatorWorker());
            calc.SetWorker(worker);

            calc.Add(2, 2);

            A.CallTo(() => worker.AddIt(2, 2)).MustHaveHappenedOnceExactly();
        }
        
        [Fact]
        public void Calculator_Subtract_Success()
        {
            var worker = A.Fake<ICalculatorWorker>();

            var calc = new Calculator(new CalculatorWorker());
            calc.SetWorker(worker);

            calc.Subtract(2, 2);

            A.CallTo(() => worker.SubtractIt(2, 2)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Calculator_Multiply_Success()
        {
            var worker = A.Fake<ICalculatorWorker>();
                        
            var calc = new Calculator(new CalculatorWorker());
            calc.SetWorker(worker);

            calc.Multiply(2, 2);

            A.CallTo(() => worker.MultiplyIt(2, 2)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Calculator_Divide_Success()
        {
            var worker = A.Fake<ICalculatorWorker>();

            var calc = new Calculator(new CalculatorWorker());
            calc.SetWorker(worker);

            calc.Divide(2, 2);

            A.CallTo(() => worker.DivideIt(2, 2)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Calculator_Foo_Success()
        {
            var worker = A.Fake<ICalculatorWorker>();

            var calc = new Calculator(new CalculatorWorker());
            calc.SetWorker(worker);

            calc.Foo("foo_test");

            A.CallTo(() => worker.FooIt("foo_test")).MustHaveHappenedOnceExactly();
        }
    }

}
