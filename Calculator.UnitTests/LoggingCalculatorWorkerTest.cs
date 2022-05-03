using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsureThat;
using Xunit;
using FakeItEasy;
using Serilog;
using FluentAssertions;
//using Castle.Core.Logging;
//namespace EnsureThat.Tests
namespace Calculator
{
    public class LoggingCalculatorWorkerTest
    {
        
        [Fact]
        public void Logging_Calculator_Subtract_Success()
        {
            var fakelogger = A.Fake<ILogger>();//change the constructor s.t. logging calculator takes in a logger as a param
            var calc = new LoggingCalculatorWorker(fakelogger);
            var result = calc.SubtractIt(3, 2);
            A.CallTo(() => fakelogger.Information("Values: 2 was subtracted from 3. Result was 1")).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Logging_Calculator_AddIt_Success()
        {
            var fakelogger = A.Fake<ILogger>();//change the constructor s.t. logging calculator takes in a logger as a param
            var calc = new LoggingCalculatorWorker(fakelogger);
            var result = calc.AddIt(3, 2);
            A.CallTo(() => fakelogger.Information("Values: 3, 2 were added. Result was 5")).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Logging_Calculator_MultiplyIt_Success()
        {
            var fakelogger = A.Fake<ILogger>();//change the constructor s.t. logging calculator takes in a logger as a param

            var calc = new LoggingCalculatorWorker(fakelogger);
            var result = calc.MultiplyIt(3, 2);
            A.CallTo(() => fakelogger.Information("Values: 3, 2 were multiplied. Result was 6")).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Logging_Calculator_DivideIt_Success()
        {
            var fakelogger = A.Fake<ILogger>();//change the constructor s.t. logging calculator takes in a logger as a param
            var calc = new LoggingCalculatorWorker(fakelogger);
            var result = calc.DivideIt(12, 6);
            A.CallTo(() => fakelogger.Information("Values: 12 divided by 6. Result was 2")).MustHaveHappenedOnceExactly();
        }
        [Fact]
        public void Logging_Calculator_DivideIt_Second_Is_Zero_Success()
        {
            var fakelogger = A.Fake<ILogger>();//change the constructor s.t. logging calculator takes in a logger as a param
            var calc = new LoggingCalculatorWorker(fakelogger);
            Action action = () => calc.ModIt(10, 0);
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Logging_Calculator_ModIt_Success()
        {
            var fakelogger = A.Fake<ILogger>();//change the constructor s.t. logging calculator takes in a logger as a param
            var calc = new LoggingCalculatorWorker(fakelogger);
            var result = calc.ModIt(10, 8);
            A.CallTo(() => fakelogger.Information("Values: 10 mod 8. Result was 2")).MustHaveHappenedOnceExactly();
         }

        [Fact]
        public void Logging_Calculator_ModIt_Second_Is_Zero_Success()
        {
            var fakelogger = A.Fake<ILogger>();//change the constructor s.t. logging calculator takes in a logger as a param
            var calc = new LoggingCalculatorWorker(fakelogger);
            Action action = () => calc.ModIt(10,0);
            action.Should().Throw<ArgumentException>();
        }
        [Theory,
         InlineData(null),
         InlineData(""),
         InlineData("  ")]
        public void Logging_cgalculator_FooIt_Success(string bar)
        {
            var fakelogger = A.Fake<ILogger>();
            var calc = new LoggingCalculatorWorker(fakelogger);
            Action action = () => calc.FooIt(bar);
            action.Should().Throw<ArgumentException>().Which.ParamName.Should().Be("bar");
        }
    }
}
         
   
