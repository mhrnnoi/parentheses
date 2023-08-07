namespace parantez;
public static class Checker
{
    public static bool Check(string input)
    {
        var stack = new Stack<char>();
        foreach (var item in input)
        {
            if ("([{".Contains(item))
                stack.Push(item);
            else if ((stack.Any()) && (")]}".IndexOf(item) == "([{".IndexOf(stack.Peek())))
                stack.Pop();
            else
                return false;
        }
        return !stack.Any();
    }
}