public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        var result = new List<List<int>>();
        Array.Sort(nums); // Step 1: sort the array

        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Skip duplicate values for i to avoid duplicate triplets
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            // Small optimization: if smallest possible sum > 0, no point continuing
            if (nums[i] > 0)
                break;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Skip duplicates for left
                    while (left < right && nums[left] == nums[left + 1])
                        left++;

                    // Skip duplicates for right
                    while (left < right && nums[right] == nums[right - 1])
                        right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++; // need a bigger sum, move left pointer right
                }
                else
                {
                    right--; // need a smaller sum, move right pointer left
                }
            }
        }

        return result;
    }
}
