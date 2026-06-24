public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // Dictionary of encountered anagrams
        // [alphabetized string, List<string> of anagrams]

        Dictionary <string, List<string>> seen = new();

        foreach (string word in strs)
        {
            char [] charray = word.ToCharArray();
            Array.Sort(charray);
            string anagramKey = new string(charray);

            Console.WriteLine($"Key:{anagramKey}");

            if (!seen.ContainsKey(anagramKey))
            {
                seen[anagramKey] = new List<string>();
            }

                seen[anagramKey].Add(word);
            
        }

        return seen.Values.ToList();
    }
}
