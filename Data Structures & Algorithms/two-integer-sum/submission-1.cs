public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int complement = target-nums[i];
            if(map.ContainsKey(complement)){
                int[] value = {map[complement],i};
                return value;
            }
            else{
                map[nums[i]] = i;
            }
        }
        return null;
    }
}
