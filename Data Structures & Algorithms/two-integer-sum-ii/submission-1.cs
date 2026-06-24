public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;

        while (left < right)
        {
            int curSum = numbers[left] + numbers[right];

            if (curSum > target)
            {
                right--;
            }
            else if (curSum < target)
            {
                left++;
            }
            else
            {
                return new int [] {left+1, right+1};
            }
        }

        return new int[0];

    }
}

// t=9
// t must always be larger than numbers[i] and complement[i]
// 10 + -1
// no the numbers can be negative so we cant assume this

// get the index of numbers if it contains the value in complment