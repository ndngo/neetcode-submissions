public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        // loop through array

        // get the "complement"
        // target sum - the current value

        // get the index of the current value and the index of the complement
        // if cant find the complement, move to the next index
        // if we run out of numbers before finding a pair, return false

        // complement, index

        Dictionary <int, int> seen = new();

        for (int i = 0 ; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            Console.WriteLine();
            if (seen.ContainsKey(complement))
            {
                return new int[]{seen[complement], i}; 
            }
            else
            {
                seen.Add(nums[i], i);
            }
        }

        return new int[0];
    }
}
