﻿
namespace Calculator.Interfaces
{
    public interface ICalculatorService
    {
        public double Addera(double value1, double value2);

        public int Subtrahera(int value1, int value2);

        public int Multiplicera(int value1, int value2);
        
        public int Modulo(int value1, int modulo);
    }
}
