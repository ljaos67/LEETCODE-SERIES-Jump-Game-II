public class Solution {
    public int Jump(int[] nums) 
    {
       int count = 0;
        int end = 0;
        int furthest = 0;
        for(int i = 0; i < nums.Length -1; i++)
        {
            furthest = (furthest > i + nums[i] ? furthest : i + nums[i]);
            if(i == end)
            {
                count++;
                end = furthest;
            }

        }
        return count;
    }
}
