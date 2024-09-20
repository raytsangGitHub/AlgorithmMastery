namespace LeetCode150Lib.SharedOperations.Merge.Array
{
    public class MergeSortedArray_88_InPlace : IAlgoMasteryOperation<int[]>
    {
        //You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
        // the above requirement is to use in-place memory
        //Merge nums1 and nums2 into a single array sorted in non-decreasing order.

        public int[] Execute(params object[] parameters)
        {
            //create the array nums1 and nums2
            var n1 = (int[])parameters[0];
            var nums2 = (int[])parameters[1];

            //Construct nums1 size to be n+m
            var nums1 = new int[n1.Length + nums2.Length];
            // and initialize the value for array nums1
            for (var j = 0; j < n1.Length; j++)
            {
                nums1[j] = n1[j];
            }

            int p1 = n1.Length - 1;
            int p2 = nums2.Length - 1;
            int tp = n1.Length + nums2.Length - 1;

            //Since both arrays sorted. we compare backward of both array, one of the number will be the greatest and will place at the end of the in-place array.
            while (p2 >= 0) // Ensure to loop as long as nums2 has elements
            {
                // If p1 true, nums1[p1] is greater than nums2[p2], put nums1[p1] at the end,  decrement p1
                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[tp] = nums1[p1];
                    p1--;
                }
                else
                {// else, put nums2[p2] at the end and decrement p2
                    nums1[tp] = nums2[p2];
                    p2--;
                }
                tp--; //
            }
            return nums1;
        }
    }
}