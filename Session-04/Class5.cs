using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class5 {

        public Class5()
        {

        }

		public int[] SortInsertion(int[] arr){

			int arrayLength = arr.Length;
			int current;
			int j ;

			for (int i = 1; i < arrayLength; ++i){
				current = arr[i];
				j = i - 1;

				while (j >= 0 && arr[j] > current)
				{
					arr[j + 1] = arr[j];
					j = j - 1;
				}
				arr[j + 1] = current;
			}
			return arr;
		}
	}

}