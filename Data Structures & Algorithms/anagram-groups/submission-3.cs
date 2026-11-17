public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // anagrams are different words that use the same letters

        Dictionary<string, List<string>> anagrams = new();

        foreach (string s in strs)
        {
            char[] charArray= s.ToCharArray();
            Array.Sort(charArray);

            string sortedKey = new string(charArray);

            if (anagrams.ContainsKey(sortedKey))
            {
                anagrams[sortedKey].Add(s);
            }
            else
            {
                anagrams[sortedKey] = new List<string>(){s};
            }
        }

        return new List<List<string>>(anagrams.Values);

    }
}
