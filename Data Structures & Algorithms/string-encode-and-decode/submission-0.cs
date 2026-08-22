public class Solution {

   public string Encode(IList<string> strs) {
        var sb = new System.Text.StringBuilder();
        foreach (var s in strs) {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            // Find the delimiter '#'
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            
            // Parse the length before '#'
            int length = int.Parse(s.Substring(i, j - i));
            
            // Extract the actual string of that length
            int start = j + 1;
            string str = s.Substring(start, length);
            result.Add(str);
            
            // Move pointer past this encoded string
            i = start + length;
        }
        return result;
    }
}
