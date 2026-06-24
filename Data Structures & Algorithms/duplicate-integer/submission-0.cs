public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> seen = new List<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(seen.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                seen.Add(nums[i]);
            }
        }

        return false;
        // loop through the nums, add them to the dictionary if i have not seen them, otherwise reeturn false
    }
}