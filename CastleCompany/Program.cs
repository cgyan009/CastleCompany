using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,6,6,8,1,1,1,2,3,3,2,2 }; //as an sample to test the algorithm
            int nums = GetNumOfCastles(array);
            Console.WriteLine($"Castles to be built: {nums}");
            Console.ReadKey();
        }
        static int GetNumOfCastles(int[] landArray)
        {
            int numOfCastles = 0; 
            //remove duplicated data from landArray and store the reduced data to tmpList
            List<int> tmpList = new List<int>();
            if (landArray == null || landArray.Length == 0)
            {
                return -1;
            }
                
            if (landArray.Length < 3)
            {
                return 1; //if array contains less than 3 elements, only 1 castle will be built
            }
            else
            {
                tmpList.Add(landArray[0]);
                for (int i = 0; i < landArray.Length - 2; i++)
                {
                    //if the second data not equal to the first one, then put it into tmpList, and so on
                    if (landArray[i+1] != landArray[i])
                    {
                        tmpList.Add(landArray[i+1]);
                    }
                }
                //convert tmpList to a new array without the continueous duplicated data
                int[] newArray = tmpList.ToArray<int>();
                for (int i = 0; i <= newArray.Length - 3; i++) 
                {
                    //count the peaks and valleys
                    if((newArray[i+1]> newArray[i] && newArray[i+1]> newArray[i+2]) || 
                        (newArray[i + 1] < newArray[i] && newArray[i + 1] < newArray[i + 2]))
                    {
                        numOfCastles++;
                    }
                }
            }
            return numOfCastles;
        }
    }
}
