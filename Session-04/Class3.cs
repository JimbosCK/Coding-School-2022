using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class3 {

        public Class3(){

        }

        public string FindPrimeNumbers(int limit){
            string primeNumbers = string.Empty;
            bool isPrime = true;

            //2 is the only even prime number so this is the only even number we will check/add.
            if (limit >= 2) {
                primeNumbers += "2";
            }
            for (int i = 3; i <= limit; i+=2){
                for (int j = i-2; j >= 3; j-=2)
                {
                    if (i % j == 0){
                        isPrime = false;
                        break; //not prime
                    }
                }
                if (isPrime)
                {
                    primeNumbers += ", " + Convert.ToString(i);
                }
                else {
                    isPrime = true;
                }
            }

            return primeNumbers;
        }
    }
}
