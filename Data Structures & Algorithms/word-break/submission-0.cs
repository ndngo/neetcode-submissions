public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        bool [] breakable = new bool[s.Length + 1];
        breakable[s.Length] = true;

        for(int i = s.Length - 1; i >= 0; i--)
        {
            foreach (string word in wordDict)
            {
                // check if we're out of bounds
                // chcek if the substring is thee same as the word from the word dictionary
                if ((i + word.Length) <= s.Length &&
                    s.Substring(i, word.Length) == word)
                {
                    breakable[i] = breakable[i + word.Length];
                }

                if (breakable[i])
                {
                    break;
                }
            }
        }

        return breakable[0];
    }
}
