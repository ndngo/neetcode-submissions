public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int arrayProduct = 1;
        int zeroCount = 0;
        foreach(int num in nums)
        {
            if (num==0)
            {
                zeroCount++;
                continue;
            }

            arrayProduct *= num;
        }

        if (zeroCount > 1)
        {
            return new int[nums.Length];
        }

        int [] result = new int [nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            

            if (zeroCount > 0)
            {
                result[i] = (nums[i] == 0) ? arrayProduct : 0;
            }
            else
            {
                result[i] = arrayProduct / nums[i];
            }
        }

        return result;
    }
}
