public class Solution {
    public void ReverseString(char[] s) {
        n = new char[s.Length];
        for (int i = 0; i < s.Length-1; i++){
            n += s[s.Length-1-i];
        }
        return n;
    }
}