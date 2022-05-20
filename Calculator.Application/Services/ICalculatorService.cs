namespace Calculator.Application.Serivecs
{
    public interface ICalculatorService
    {
        int Puls(int firstNumber, int secondNumber);
        int Minus(int firstNumber, int secondNumber);
        int Multiplication(int firstNumber, int secondNumber);
        int Division(int firstNumber, int secondNumber);
    }
}