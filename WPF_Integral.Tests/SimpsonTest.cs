using WPF_Integral.Classes;
namespace WPF_Integral.Tests
{
    public class SimpsonTest
    {
        [Fact]
        public void Simpson_XX_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 1000;
            double lowerLimit = 1;
            int count = 1000;
            Func<double, double> integralFunction = x => 2 * x - Math.Log(11 * x) - 1;

            double expectedResult = 990695.75312256254;

            //Act (Действия)
            Simpson calculator = new Simpson();
            double actualResult = calculator.Integrate(lowerLimit, upperLimit, count, integralFunction);

            //Assert (Сравнение)
            Assert.Equal(expectedResult, actualResult, 0.01);
        }
        [Fact]
        public void Simpson_X1_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 1000;
            double lowerLimit = 1;
            int count = 100;
            Func<double, double> integralFunction = x => 2 * x - Math.Log(11 * x) - 1;

            double expectedResult = 990697.56798643514;

            //Act (Действия)
            Simpson calculator = new Simpson();
            double actualResult = calculator.Integrate(lowerLimit, upperLimit, count, integralFunction);

            //Assert (Сравнение)
            Assert.Equal(expectedResult, actualResult, 0.01);
        }
        
        [Fact]
        public void Simpson_Count_Negative_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 100;
            double lowerLimit = 1;
            int count = 1000;
            Func<double, double> integralFunction = x => 2 * x - Math.Log(11 * x) - 1;

            double expectedResult = 9301.0913504469681;

            //Act (Действия)
            Simpson calculator = new Simpson();
            double actualResult = calculator.Integrate(lowerLimit, upperLimit, count, integralFunction);


            //Assert (Сравнение)
            Assert.Equal(expectedResult, actualResult, 0.01);
        }

    }
}

