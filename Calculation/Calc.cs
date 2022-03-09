
using System.Linq;

namespace Calculation {
    public class Calc {
        private static int _maxPosibleOperations = 1;

        public Calc() { 
        
        }

        public string Calculate(string request) {
            MathExpression expression = new MathExpression(request);
            //string OperationSymbol = FindOperationSymbol(request);
            //string[] splitRequest = SplitRequest(request);
            //string response = string.Empty;
            //if (splitRequest.Length > 2) {
            //  return String.Empty;
            //}
            if (!expression.IsValid()) { return string.Empty; }
            Operation operation = null;
            // TO DO: [Refactor] Change case checks to Enum instead of strings
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

        private static string FindOperationSymbol(string request){
            int numberOfOperationsFound = 0;
            string result = string.Empty;
            foreach (char character in request) {
                if (System.Enum.IsDefined(typeof(OperationsEnum), (int)(character))) {
                    result = character.ToString();
                    numberOfOperationsFound++;
                }
            }
            if (numberOfOperationsFound > _maxPosibleOperations) {
                return "abort";
            }

            return result;
        }

        private static string[] SplitRequest(string request) {
            var numberOfOperations = Enum.GetNames(typeof(OperationsEnum)).Length;
            char[] delimiters = new char[numberOfOperations];
            int j = 0;
            foreach (int i in Enum.GetValues(typeof(OperationsEnum))) {
                delimiters[j++] = (char)i;
            }

            return request.Split(delimiters);
        }
    }
}