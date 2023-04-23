using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MergeSortNumberListService
{
    /// <summary>
    /// Summary description for MergeSortNumberList
    /// </summary>
    [WebService(Namespace = "http://localhost:64666/Service1.svc?wsdl")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MergeSortNumberList : System.Web.Services.WebService
    {

        [WebMethod]
        public string SortService(string userInput)
        {
            string output = "";

            string[] inputArr = userInput.Split(' '); // convert input string into a string array delimited by a space
            List<int> unsortedNums = Array.ConvertAll(inputArr, int.Parse).ToList(); // convert str array into a List<int>

            unsortedNums = MergeSort(unsortedNums); // merge sort
            output = string.Join(" ", unsortedNums); // convert sorted List<int> back into a string

            return output;
        }

        [WebMethod]
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

        [WebMethod]
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
