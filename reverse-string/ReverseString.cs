using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return "";
        }

        //return new string(input.Reverse().ToArray());
        var reversed = new StringBuilder();

        for(int i = input.Length-1; i>=0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();

    }
}