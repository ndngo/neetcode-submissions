public class Solution {
    public bool IsValid(string s) {
        
        Stack <char> stack = new ();
        Console.WriteLine($"Init stack:");

        foreach (char c in s)
        {
            Console.WriteLine($"c: {c}");

            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
                Console.WriteLine($"Pushing: {c}");
            }
            else if (stack.Count > 0
                && (c == ')' || c == '}' || c == ']' )
                && IsPair(stack.Peek(), c))
            {
                Console.WriteLine($"Pop: {stack.Peek()}");
                stack.Pop();
            }
            else
            {
                return false;
            }
        }

        Console.WriteLine($"Done reading string");
        return stack.Count == 0;

    }

    public bool IsPair(char c, char d)
    {
        if (c == '(' && d == ')')
        {
            return true;
        }

        if (c == '{' && d == '}')
        {
            return true;
        }

        if (c == '[' && d == ']')
        {
            return true;
        }

        return false;
    }
}
