namespace LeetCode150Lib.TwoPointers
{
    public class TwoSumII167 : ITwoPointerOperation<int[]>
    {
        //find any two number sum to a k value. input array is sorted.
        // Input: numbers = [2,7,11,15], target = 9
        // Output: [1, 2]

        public int[] Execute(params object[] parameters)
        {
            int[] output = new int[2];
            var input = parameters[0];
            //require cast else this line won't work: if (inputStr[left] + inputStr[right] == k)
            var k = (int)parameters[1];
            if (input is int[] inputStr)
            {
                int left = 0;
                int right = parameters.Length - 1;
                while (left < right)
                {
                    // make the first pointer at 0 index
                    if (inputStr[left] + inputStr[right] == k)
                    {
                        output[0] = left + 1;
                        output[1] = right + 1;
                        break;
                    }
                    else if (inputStr[left] + inputStr[right] > k) //k < the sum
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return output;
        }
    }
}