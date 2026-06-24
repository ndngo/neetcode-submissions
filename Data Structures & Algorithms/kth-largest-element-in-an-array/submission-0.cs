public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> minHeap = new();
        foreach (int num in nums)
        {
            // Adds the specified element with associated priority to the
            minHeap.Enqueue(num, num);
            if (minHeap.Count > k)
            {
                // Removes and returns the minimal element from the
                minHeap.Dequeue();
            }
        }

        // Returns the minimal element without removing it
        return minHeap.Peek();
    }
}
