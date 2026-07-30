public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        for(int a = 0;a<nums.Length;a++){
            if(count.ContainsKey(nums[a])){
                return true;
            }
            else{
                count[nums[a]] = 1;
            }
        }
        return false;
    }
}