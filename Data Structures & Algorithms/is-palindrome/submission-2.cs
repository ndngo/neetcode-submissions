public class Solution {
    public bool IsPalindrome(string s) {
        
        s = Regex.Replace(s, @"[^A-Za-z0-9]+", String.Empty).ToLower();
        Console.WriteLine(s);
        char [] str = s.ToCharArray();

        for(int i = 0; i < str.Length;i++)
        {
            char left = str[i];
            char right = str[str.Length - 1 - i];

            if (left != right)
            {
                return false;
            }
        }

        return true;

    }
}
