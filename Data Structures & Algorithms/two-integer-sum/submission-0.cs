public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>(); 
        for(int i=0;i<nums.Length;i++){
            int complement = target-nums[i];
            if(map.ContainsKey(complement)){
                int[] a = {map[complement],i};
                return a;
            }
            else{
                map[nums[i]] = i;
            }
        }
        return null;
    }
}
