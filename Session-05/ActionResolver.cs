using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {

    internal class ActionResolver : Resolver{

        public MessageLogger Logger{ get; set; }

        public ActionResolver() {
            Logger = new MessageLogger();
        }


        public ActionResponse Excecute(ActionRequest request){
            var response = new ActionResponse();
            response.RequestID = request.RequestID;

            switch (request.Action) {
                case ActionEnum.Convert:
                    response.Output = DecimalToBinary(request.Input);
                    if (response.Output != null) {
                        LogEventMessage(request.RequestID, request.Input, response.Output, request.Action, DateTime.Now);
                    }

                    break;
                case ActionEnum.Uppercase:
                    response.Output = MakeBiggestWordUpper(request.Input);
                    if (response.Output != null)
                    {
                        LogEventMessage(request.RequestID, request.Input, response.Output, request.Action, DateTime.Now);
                    }
                    break;
                case ActionEnum.Reverse:
                    response.Output = ReverseString(request.Input);
                    if (response.Output != null) {
                        LogEventMessage(request.RequestID, request.Input, response.Output, request.Action, DateTime.Now);
                    }
                    break;
                default:
                    response.Output = null;
                    LogEventError(request.RequestID, request.Input, request.Action, DateTime.Now);
                    break;
                
            }

            return response;
        }

        private string DecimalToBinary(string input)
        {
            try
            {
                if(input == null)
                {
                    throw new ArgumentException("Parameter cannot be null", nameof(input));
                }
                string outputBinary = null;
                int number;
                if (Int32.TryParse(input, _style, _culture, out number))
                {
                    outputBinary = CalculateBinary(number);
                }
                return outputBinary;
            }
            catch (Exception ex)
            {
                LogEventExceptionConvert(input, ex, DateTime.Now);
                return null;
            }
        }

        private string? CalculateBinary(int number)
        {
            string result = string.Empty;

            while (number > 1)
            {
                int remainder = number % 2;
                result = Convert.ToString(remainder) + result;
                number /= 2;
            }
            result = Convert.ToString(number) + result;

            return result;
        }

        private string ReverseString(string str){
            try
            {
                if (str.Length > 0)
                    return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
                else
                    return str;
            }
            catch (Exception ex)
            {
                LogEventExceptionReverse(str, ex, DateTime.Now);
                return null;
            }
        }

        //TO DO: [Refactor] MakeBiggestWordUpper
        private string MakeBiggestWordUpper(string str){
            int numOfWords = 0;
            int maxLengthOfWord = 0;
            int? indexOfBiggestWord = null;
            string outputUpper = str;
            
            try
            {
                string[] words = str.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] != String.Empty)                    {
                        numOfWords++;
                        if (words[i].Length > maxLengthOfWord)
                        {
                            maxLengthOfWord = words[i].Length;
                            indexOfBiggestWord = i;
                        }
                    }
                }
                if (indexOfBiggestWord != null && numOfWords > 1)
                {
                    words[(int)indexOfBiggestWord] = words[(int)indexOfBiggestWord].ToUpper();
                    outputUpper = string.Join(' ', words);
                }
            }
            catch (Exception ex)
            {
                LogEventExceptionUppercase(str, ex, DateTime.Now);
                return null;
                
            }
            
               
            return outputUpper;
        }

        protected override void LogEventMessage(string description, DateTime timeStamp)
        {
            Logger.Write(new Message()
            {
                Text = description,
                Timestamp = timeStamp
            });
        }

        protected override void LogEventMessage(Guid requestID, string requestInput, string requestOutput,ActionEnum action, DateTime timeStamp)
        {
            Logger.Write(new Message(){
                Text = $"Request [{requestID}] : Opperation {action} on input: '{requestInput}'. Response output: '{requestOutput}' .",
                Timestamp = timeStamp
            });
        }

        protected override void LogEventError(Guid requestID, string requestInput, ActionEnum action, DateTime timeStamp)
        {
            Logger.Write(new Message()
            {
                Text = $"## ERROR: Request [{requestID}] : Received Unhandled Action '{action}' with input: '{requestInput}'. Skipping request.",
                Timestamp = timeStamp
            });
        }

        private void LogEventExceptionUppercase(string requestInput, Exception exeption, DateTime timeStamp)
        {
            LogEventExceptionBasic(requestInput, exeption, timeStamp, ActionEnum.Uppercase);
        }

        private void LogEventExceptionReverse(string requestInput, Exception exeption, DateTime timeStamp)
        {
            LogEventExceptionBasic(requestInput, exeption, timeStamp, ActionEnum.Reverse);
        }

        private void LogEventExceptionConvert(string requestInput, Exception exeption, DateTime timeStamp)
        {
            LogEventExceptionBasic(requestInput, exeption, timeStamp, ActionEnum.Convert);
        }
        private void LogEventExceptionBasic(string requestInput, Exception exeption, DateTime timeStamp, ActionEnum action)
        {
            Logger.Write(new Message()
            {
                Text = $"## Exception in Action [{action}]: {exeption}. Request inp'{requestInput}'.",
                Timestamp = timeStamp
            });
        }
    }
}
