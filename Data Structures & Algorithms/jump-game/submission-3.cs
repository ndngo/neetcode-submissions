public class Solution {
    public bool CanJump(int[] nums) {
    
        // the goal is to get to the end of nums
        int goal = nums.Length-1;

        // we start by checking if the second last element is within jumping distance to the end
        // if it is, we confirm the jump and set it as the new goal
        // we redefine the goal from the end to a substep towards the end
        // and we just iterate towards the beginning

        for (int i = nums.Length-2; i>=0; i--)
        {
            if (nums[i]>=goal-i)
            {
                goal = i;
            }
        }

        if (goal==0)
        {
            return true;
        }
        
        return false;
    }

}
