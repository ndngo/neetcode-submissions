public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
        {
            return false;
        }

        // count the letters for both strings using Dictionary<char, int>

        //compare the Dictionaries if they have the same content

        // STOP & POTS & TOPS & OTPS

        Dictionary<char, int> count = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            count[s[i]] = count.GetValueOrDefault(s[i], 0) + 1;
        }

        for (int i = 0; i < t.Length; i++)
        {
            count[t[i]] = count.GetValueOrDefault(t[i], 0) - 1;
        }

        return count.Values.All(v => v == 0);
    }
}
