public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        
        while (left < right) {
            int currentSum = numbers[left] + numbers[right];
            
            if (currentSum == target) {
                // Found it! Return 1-indexed positions
                return new int[] { left + 1, right + 1 };
            }
            else if (currentSum < target) {
                // Sum too small, need a bigger number -> move left pointer right
                left++;
            }
            else {
                // Sum too big, need a smaller number -> move right pointer left
                right--;
            }
        }
        
        // Problem guarantees a solution exists, so we never actually reach this
        return new int[] { -1, -1 };
    }

}
