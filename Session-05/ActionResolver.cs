using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class ActionResolver {

        public MessageLogger Logger{ get; set; }

        public ActionResolver() {
            Logger = new MessageLogger();
        }


        public ActionResponse Excecute(ActionRequest request){
            var response = new ActionResponse();
            response.RequestID = request.RequestID;

            switch (request.Action) {
                case ActionEnum.Convert:
                    break;
                case ActionEnum.Uppercase:
                    response.Output = MakeBiggestWordUpper(request.Input);
                    Logger.Write( new Message() { 
                        Text = $"Request [{request.RequestID}] : Attempting Uppercase on string: '{request.Input}'. Response output: '{response.Output}' .",
                        Timestamp = DateTime.Now
                    }); 
                    break;
                case ActionEnum.Reverse:
                    break;
                
            }

            return response;
        }

        //TO DO: [Refactor] MakeBiggestWordUpper
        private string MakeBiggestWordUpper(string str){
            int numOfWords = 0;
            int maxLengthOfWord = 0;
            int? indexOfBiggestWord = null;
            string outputUpper = str;

            string[] words = str.Split(' ');
                for (int i = 0; i < words.Length; i++){
                    if (words[i] != String.Empty){
                        numOfWords++;
                        if (words[i].Length > maxLengthOfWord){
                            maxLengthOfWord = words[i].Length;
                            indexOfBiggestWord = i;
                        }
                    }
                }
            if (indexOfBiggestWord != null && numOfWords > 1) {
                words[(int)indexOfBiggestWord] = words[(int)indexOfBiggestWord].ToUpper();
                outputUpper = string.Join(' ', words);
            }
            return outputUpper;
        }

    }
}
