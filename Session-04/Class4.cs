using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class4 {
        public Class4()
        {

        }


        public int[] Multiply2_4(int[] array1, int[] array2){
            int[] resultArray = new int[16];

            for (int i = 0; i < 4; i++){
                for (int j = 0; j < 4; j++)
                {
                    resultArray[(i * 4) + j] = array1[i] * array2[j];
                    //Console.WriteLine($"i*j= {i * j} | array1[i] * array2[j] = {array1[i] * array2[j]}");
                }
            }


            return resultArray;    
        }
    }
}
