public class Solution {
    public int Jump(int[] nums) {
        int result = 0;
        int l = 0, r = 0;
        // use two pointers

        // while right pointer is not at the last element
        // we can break down the array into sections based on how many steps it takes to get there
        // L points to the shortest hop you can make
        // R points to the longest hop you can make

        while (r < nums.Length - 1)
        {
            int farthest = 0;

            // iterate from L to R and find the farthest out of the current section
            for (int i = l;i< r + 1;i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);
            }

            // move L and R pointers
            // increment number of steps every step we take

            l = r + 1;
            r = farthest;
            result += 1;
        }

        return result;
    }
}
