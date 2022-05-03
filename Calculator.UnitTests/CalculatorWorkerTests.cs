using System;
using FluentAssertions;
using Xunit;

namespace Calculator
{
    public class CalculatorWorkerTests
    {
        [Fact]
        public void CalculatorWorker_AddIt_Success()
        {
            var calc = new CalculatorWorker();
            var result = calc.AddIt(2, 2);
            result.Should().Be(4);
        }

        [Fact]
        public void CalculatorWorker_SubtractIt_Success()
        {
            var calc = new CalculatorWorker();
            var result = calc.SubtractIt(12, 2);
            result.Should().Be(10);
        }

        [Fact]
        public void CalculatorWorker_MultiplyIt_Success()
        {
            var calc = new CalculatorWorker();
            var result = calc.MultiplyIt(2, 3);
            result.Should().Be(6);
        }

        [Fact]
        public void CalculatorWorker_DivideIt_Success()
        {
            var calc = new CalculatorWorker();
            var result = calc.DivideIt(12, 3);
            result.Should().Be(4);
        }

        [Fact]
        public void CalculatorWorker_ModIt_Success()
        {
            var calc = new CalculatorWorker();
            var result = calc.ModIt(12, 2);
            result.Should().Be(0);
        }

        [Fact]
        public void CalculatorWorker_DivideIt_ThrowsWhenDenominatorIsZero()
        {
            var calc = new CalculatorWorker();
            Action action = () => calc.DivideIt(12, 0);
            action.Should().Throw<ArgumentException>().Which.ParamName.Should().Be("second");
        }

        [Fact]
        public void CalculatorWorker_ModIt_ThrowsWhenDenominatorIsZero()
        {
            var calc = new CalculatorWorker();
            Action action = () => calc.ModIt(12, 0);
            action.Should().Throw<ArgumentException>().Which.ParamName.Should().Be("second");
        }

        [Theory,
         InlineData(null),
         InlineData(""),
         InlineData("  ")]
        public void CalculatorWorker_FooIt_NullOrWhitespaceThrows(string bar)
        {
            var calc = new CalculatorWorker();
            Action action = () => calc.FooIt(bar);
            action.Should().Throw<ArgumentException>().Which.ParamName.Should().Be("bar");
        }
    }
}
