public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<List<int>> result = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                break;
            }

            if (i > 0 && nums[i] == nums[i-1])
            {
                continue;
            }

            int L = i + 1, R = nums.Length - 1;

            while(L < R)
            {
                int sum = nums[i] + nums[L] + nums[R];

                if (sum > 0)
                {
                    R--;
                }
                else if (sum < 0)
                {
                    L++;
                }
                else
                {
                    result.Add(new List<int>{nums[i], nums[L], nums[R]});
                    L++;
                    R--;
                    
                    while (L < R && nums[L] == nums[L-1])
                    {
                        L++;
                    }
                }
            }
        }

        return result;
    }
}
