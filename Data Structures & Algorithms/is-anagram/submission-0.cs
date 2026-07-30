public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] first = s.ToCharArray();
        char[] second = t.ToCharArray();
        Array.Sort(first);

        Array.Sort(second);
        s= new string(first);
        t= new string(second);
        if(s==t)return true;
        else return false;
    }
}
