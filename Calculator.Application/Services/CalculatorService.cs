namespace Calculator.Application.Serivecs
{
    public class CalculatorService : ICalculatorService
    {
        public int Puls(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Minus(int firstNumber, int secondNumber)
        {
           return firstNumber - secondNumber;
        }

        public int Multiplication(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Division(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}