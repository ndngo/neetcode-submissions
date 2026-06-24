public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> mp = new Dictionary<int, int>();

        for (int i = 0 ; i < numbers.Length; i++)
        {
            int tmp = target - numbers[i];
            if (mp.ContainsKey(tmp))
            {
                return new int[] {mp[tmp], i+1};
            }
            mp[numbers[i]] = i+1;
        }
        return new int[0];
    }
}

// t=9
// t must always be larger than numbers[i] and complement[i]
// 10 + -1
// no the numbers can be negative so we cant assume this

// get the index of numbers if it contains the value in complment