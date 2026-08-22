public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            // Move left pointer forward until it hits an alphanumeric char
            while (left < right && !char.IsLetterOrDigit(s[left])) {
                left++;
            }

            // Move right pointer backward until it hits an alphanumeric char
            while (left < right && !char.IsLetterOrDigit(s[right])) {
                right--;
            }

            // Compare characters (case-insensitive)
            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
