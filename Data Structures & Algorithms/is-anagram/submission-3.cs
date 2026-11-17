public class Solution {
    public bool IsAnagram(string s, string t) {

        if (String.IsNullOrWhiteSpace(s) || String.IsNullOrWhiteSpace(t) || s.Length!=t.Length)
        {
            return false;
        }

        Dictionary <char, int> seen = new();

        foreach (char c in s)
        {
            if (seen.ContainsKey(c))
            {
                seen[c]++;
            }
            else
            {
                seen.Add(c, 1);
            }
        }

        foreach (char c in t)
        {
            if (!seen.ContainsKey(c))
            {
                return false;
            }

            if (seen.ContainsKey(c) && seen[c] == 1)
            {
                seen.Remove(c);
            }
            else
            {
                seen[c]--;
            }
        }

        return seen.Count == 0;

    }
}
