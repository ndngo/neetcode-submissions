public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // priority queue <int, int>
        PriorityQueue<int, int> leaderboard = new();
        // loop through nums

        foreach(int num in nums)
        {
            leaderboard.Enqueue(num, num);
            if (leaderboard.Count > k)
            {
                leaderboard.Dequeue();
            }
        }

        // enqueue, dequeue whn hitting limit k



        return leaderboard.Peek();
        // return the topmost element
    }
}
