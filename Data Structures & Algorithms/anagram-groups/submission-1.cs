public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // alphabetize the string
        // Dictionary<string, int> anagrams
        // use thee alphabetized string as the key
        // store original anagram in List string value
        Dictionary<string, List<string>> anagrams = new();

        foreach (string s in strs)
        {
            char [] charray = (s.ToCharArray());
            Array.Sort(charray);
            string anagramKey = new string(charray);

            // new
            if (!anagrams.ContainsKey(anagramKey))
            {
                anagrams[anagramKey] = new List<string>();
                //anagrams.Add(anagramKey, new List<string> () {s} );
            }

            anagrams[anagramKey].Add(s);

        }
        // Dictionary Values as List

        return anagrams.Values.ToList();
    }
}
