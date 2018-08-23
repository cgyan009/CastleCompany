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
            int[] array = {1,6,6,8,1,1,1,2,3,3,2,2 };
            int nums = GetNumOfCastles(array);
            Console.WriteLine($"Castles to be built: {nums}");
            Console.ReadKey();
        }
        static int GetNumOfCastles(int[] landArray)
        {
            int numOfCastles = 0;
            List<int> tmpList = new List<int>();
            if (landArray == null)
                return -1;
            if (landArray.Length < 3)
                return 1;
            
            else
            {
                tmpList.Add(landArray[0]);
                for (int i = 0; i < landArray.Length - 2; i++)
                {
                    if (landArray[i+1] != landArray[i])
                    {
                        tmpList.Add(landArray[i+1]);
                    }
                }
                int[] newArray = tmpList.ToArray<int>();
                for (int i = 0; i <= newArray.Length - 3; i++)
                {
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
