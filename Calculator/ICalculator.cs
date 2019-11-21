namespace Calculator
{
    public interface ICalculator
    {
        bool AddOperator(Operator operation);

        void AddOperand(string operand);

        bool AddComma();

        double GetResult();

        double FlipSign();

        double DivideBy100();

        void Reset();
    }
}

