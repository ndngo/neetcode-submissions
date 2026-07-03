public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> q = new();

        foreach(int num in nums)
        {
            q.Enqueue(num, num);
            if (q.Count > k)
            {
                q.Dequeue();
            }
        }

        return q.Peek();
    }
}
