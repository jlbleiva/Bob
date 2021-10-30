using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if ((!ThereAreSomething(statement)) && !IsQuestion(statement))  return "Fine. Be that way!";
        if (IsQuestion(statement) && (IsUpper(statement)))
            return "Calm down, I know what I'm doing!";
        else if (IsQuestion(statement)) return "Sure.";
        else if (IsUpper(statement)) return "Whoa, chill out!";
       
        return "Whatever.";
    }

    public static bool IsQuestion(string str)
    {
        str = str.Trim();
        if (str.Length == 0) return false;
        else if (str[str.Length - 1].ToString() == "?") return true;
        return false;
    }

    public static bool IsUpper(string str)
    {
        return (str == str.ToUpper() && ThereAreLetters(str));
    }

    public static bool ThereAreLetters(string str)
    {
        return (str.Any(c => char.IsLetter(c)));
    }

    public static bool ThereAreSomething(string str)
    {
        return (str.Any(c => char.IsLetter(c)) == true | str.Any(c => char.IsDigit(c)) == true);
    }
}