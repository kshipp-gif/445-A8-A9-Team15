using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MergeSortNumberListService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string SortService(string userInput)
        {
            string output = "";

            string[] inputArr = userInput.Split(' '); // convert input string into a string array delimited by a space
            List<int> unsortedNums = Array.ConvertAll(inputArr, int.Parse).ToList(); // convert str array into a List<int>

            unsortedNums = MergeSort(unsortedNums); // merge sort
            output = string.Join(" ", unsortedNums); // convert sorted List<int> back into a string

            return output;
        }

        public List<int> MergeSort(List<int> nums)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            if (nums.Count <= 1)
                return nums;

            int mid = nums.Count / 2;
            left = nums.GetRange(0, mid);
            right = nums.GetRange(mid, nums.Count - mid);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);

        }

        public List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            int l = 0; // left sublist index
            int r = 0; // right sublist index

            while (l < left.Count && r < right.Count)
            {
                if (left[l] < right[r])
                {
                    result.Add(left[l]);
                    l++;
                }
                else
                {
                    result.Add(right[r]);
                    r++;
                }
            }

            while (l < left.Count)
            {
                result.Add(left[l]);
                l++;
            }

            while (r < right.Count)
            {
                result.Add(right[r]);
                r++;
            }

            return result;
        }
    }
}
