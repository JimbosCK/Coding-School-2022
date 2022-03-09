namespace Calculation {
    public class Calc {
        private static int _maxPosibleOperations = 1;

        public Calc() { 
        
        }

        public string Calculate(string request) {
            MathExpression expression = new MathExpression(request);
            if (!expression.IsValid()) { return string.Empty; }
            Operation operation = null;
            // TODO: [Refactor] Change case checks to Enum instead of strings
            switch (expression.OperationSymbol) {
                case "+":
                    operation = new Addition();
                    break;
                case "-":
                    operation = new Subtraction();
                    break;
                case "x":
                    operation = new Multiplication();
                    break;
                case "/":
                    operation = new Division();
                    break;
                case "^":
                    operation = new Power();
                    break;
                case "S":
                    operation = new SquareRoot();
                    break;
                case "abort":
                    return String.Empty;
                default:
                    return String.Empty;
            }

            return operation.Execute(expression);
        }

    }
}