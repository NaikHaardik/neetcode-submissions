public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;
        
        foreach (int num in numSet) {
            // Only start counting if 'num' is the START of a sequence
            // (i.e., num - 1 is NOT in the set)
            if (!numSet.Contains(num - 1)) {
                int currentNum = num;
                int currentStreak = 1;
                
                while (numSet.Contains(currentNum + 1)) {
                    currentNum++;
                    currentStreak++;
                }
                
                longest = Math.Max(longest, currentStreak);
            }
        }
        
        return longest;
    }
}
