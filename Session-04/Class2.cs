using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class2 {

        public Class2(){
            
        }

        public int CalculateSum(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++){
                sum += i;
            }

            return sum;
        }

        public double CalculateProduct(int num)
        {
            double product = 1;
            if (num < 1) { product = 0; }

            for (int i = 2; i <= num; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
