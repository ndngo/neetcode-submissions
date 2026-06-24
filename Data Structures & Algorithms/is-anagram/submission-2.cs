public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
        {
            return false;
        }
        // char, int
        // letter, frequency
        Dictionary <char, int> seen  = new();

        for (int i = 0;i<s.Length;i++)
        {
            seen[s[i]] = seen.GetValueOrDefault(s[i], 0) + 1;
        }

        for (int i = 0;i<t.Length;i++)
        {
            seen[t[i]] = seen.GetValueOrDefault(t[i], 0) - 1;
        }

        int checksum = 0;

        foreach (var entry in seen)
        {
            Console.WriteLine($"{entry.Key}:{entry.Value}");
            if (entry.Value != 0)
            {
                return false;
            }
        }

        Console.WriteLine(checksum);

        return true;
    }
}
