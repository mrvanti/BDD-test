using Calculator.Interfaces;

namespace Calculator.Implemenations
{
    public class CalculatorService: ICalculatorService
    {
        public CalculatorService()
        {

        }

        public double Addera(double value1, double value2)
        {
            return value1 + value2;
        }

        public int Multiplicera(int value1, int value2)
        {
            return value1 * value2;
        }

        public int Subtrahera(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Modulo(int value1, int modulo)
        {
            return value1 % modulo;
        }
    }
}
