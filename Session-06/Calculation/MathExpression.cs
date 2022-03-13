using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation {
    public class MathExpression {
        private  int _maxNumberOfOperationsPossible = 1;
        private  int _maxNumberOfVariablesPossible = 2;

        private  int _numberOfOperationsFound = 0;
        private  int _numberOfVariablesFound = 0;

        public string[] Variables { get; set; }
        public string OperationSymbol { get; set; }

        public int numberOfOperations { get; }
        public MathExpression(string expression) {
            OperationSymbol = FindOperationSymbol(expression);
            Variables = SplitExpression(expression);
            _numberOfVariablesFound = Variables.Length;
        }

        public bool IsValid() {
            bool isValid = true;
            
            if(HasTooManyOperations())
                isValid = false;
            if (HasTooManyVariables())
                isValid = false;
            return isValid;
        }

        private bool HasTooManyVariables() {
            if (_numberOfVariablesFound > _maxNumberOfVariablesPossible)
                return true;
            return false;
        }

        private bool HasTooManyOperations() {
            if (_numberOfOperationsFound > _maxNumberOfOperationsPossible)
                return true;
            return false;
        }
        private string FindOperationSymbol(string request) {
            string result = string.Empty;
            foreach (char character in request){
                if (System.Enum.IsDefined(typeof(OperationsEnum), (int)(character))) {
                    result = character.ToString();
                    _numberOfOperationsFound++;
                }
            }

            return result;
        }


        private static string[] SplitExpression(string request) {
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
