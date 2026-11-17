public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> seen = new ();

        foreach(int num in nums)
        {
            if (seen.ContainsKey(num))
            {
                seen[num]++;
                return true;
            }
            else
            {
                seen.Add(num, 1);
            }
        }

        return false;

    }
}