using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class1 {


        public Class1(){
            
        }  

        public string ReverseString(string str){
            if (str == null) { return string.Empty; }
            
            string reversedString = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i];
            }

            return reversedString;
        }
    }
}
