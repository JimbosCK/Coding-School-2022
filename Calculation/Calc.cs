
using System.Linq;

namespace Calculation {
    public class Calc {
        public Calc() { 
        
        }

        public string Calculate(string request) {
            string[] splitRequest = SplitRequest(request);
            string OperationSymbol = FindOperationSymbol(request);
            string response = string.Empty;
            Operation operation = null;
            // TO DO: [Refactor] Change case checks to Enum instead of strings
            switch (OperationSymbol) {
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
                default:
                    return "Error Calculating. Press Clear.";
            }

            return operation.Execute(splitRequest[0], splitRequest[1]);
        }

        private static string FindOperationSymbol(string request){
            string result = string.Empty;
            foreach (char character in request) {
                if (System.Enum.IsDefined(typeof(OperationsEnum), (int)(character))) {
                    result = character.ToString();
                }
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