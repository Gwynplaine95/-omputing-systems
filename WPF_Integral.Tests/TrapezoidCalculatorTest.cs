using WPF_Integral.Classes;
namespace WPF_Integral.Tests
{
    public class TrapezoidCalculatorTest
    {
        [Fact]
        public void Trapezoid_XX_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 10;
            double lowerLimit = 1;
            int count = 1000000;
            Func<double, double> integralFunction = x => 2 * x - Math.Log(11 * x) - 1;

            double expectedResult = 54.393091614878493;

            //Act (Действия)
            TrapezoidCalculator calculator = new TrapezoidCalculator();
            double actualResult = calculator.Integrate(lowerLimit, upperLimit, count, integralFunction);

            //Assert (Сравнение)
            Assert.Equal(expectedResult, actualResult, 0.01);
        }
        [Fact]
        public void Trapezoid_X1_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 100;
            double lowerLimit = 1;
            int count = 10000;
            Func<double, double> integralFunction = x => 2 * x - Math.Log(11 * x) - 1;

            double expectedResult = 9301.0913574799542;

            //Act (Действия)
            TrapezoidCalculator calculator = new TrapezoidCalculator();
            double actualResult = calculator.Integrate(lowerLimit, upperLimit, count, integralFunction);

            //Assert (Сравнение)
            Assert.Equal(expectedResult, actualResult, 0.01);
        }
    }
}