public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // [number we're counting the frequency of, frequency]
        
        // loop through array
        // if it dosent exist, create entry
        // if it exists, access the entry
        // +1

        Dictionary<int, int> seen = new();

        foreach(int num in nums)
        {
            if (seen.ContainsKey(num))
            {
                seen[num] += 1;
            }
            else
            {
                seen[num] = 1;
            }
        }
        // sort by value

        List<int[]> arr = seen.Select(entry => new int[] {entry.Value, entry.Key}).ToList();
        arr.Sort((a, b) => b[0].CompareTo(a[0]));

        int [] res = new int[k];

        for(int i = 0; i < k; i++)
        {
            res[i] = arr[i][1];
        }

        return res;
    }
}
