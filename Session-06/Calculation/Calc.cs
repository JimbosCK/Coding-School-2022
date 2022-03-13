namespace Calculation {
    public class Calc {
        private static int _maxPosibleOperations = 1;

        public Calc() { 
        
        }

        public string Calculate(string request) {
            MathExpression expression = new MathExpression(request);
            if (!expression.IsValid()) { return string.Empty; }
            Operation operation = null;

            var op = (OperationsEnum)Convert.ToChar(expression.OperationSymbol);

            switch (op) {
                case OperationsEnum.Plus:
                    operation = new Addition();
                    break;
                case OperationsEnum.Minus:
                    operation = new Subtraction();
                    break;
                case OperationsEnum.Multiplication:
                    operation = new Multiplication();
                    break;
                case OperationsEnum.Division:
                    operation = new Division();
                    break;
                case OperationsEnum.Power:
                    operation = new Power();
                    break;
                case OperationsEnum.SquareRoot:
                    operation = new SquareRoot();
                    break;
                default:
                    return String.Empty;
            }

            return operation.Execute(expression);
        }

    }
}