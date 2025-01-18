
class Program
{
    static void Main()
    {
        ShowText("Enter string1: ");
        string string1 = EnterString();

        ShowText("Enter string2: ");
        string string2 = EnterString();

        if (Compare(string1, string2))
            ShowText("Both strings are the same\n");
        else
            ShowText("The strings aren't the same\n");

        ShowText($"string1 has {CountLetters(string1)} letter(s)\n");
        ShowText($"string1 has {CountWords(string1)} word(s)\n");

        if (HasChar(string1, 'Q'))
            ShowText("string1 has letter Q\n");
        else
            ShowText("string1 doesn't have letter Q\n");

        if (HasSubstring(string1, "Demian"))
            ShowText("string1 has substring Demian\n");
        else
            ShowText("string1 doesn't have substring Demian\n");
    }

    static void ShowText(string text) => System.Console.Write(text);
    static string EnterString() => System.Console.ReadLine();

    static bool Compare(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        for (int i = 0; i < str1.Length; i++)
            if (str1[i] != str2[i])
                return false;

        return true;
    }

    static bool IsLetter(char ch) => (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');

    static int CountLetters(string text)
    {
        int count = 0;
        for (int i = 0; i < text.Length; i++)
            if (IsLetter(text[i]))
                count++;

        return count;
    }

    static int CountWords(string text)
    {
        int wordsCount = 0;

        bool isWordStarted = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (IsLetter(text[i]) && !isWordStarted)
            {
                isWordStarted = true;
                wordsCount++;
            }
            else if (!IsLetter(text[i]))
            {
                isWordStarted = false;
            }
        }

        return wordsCount;
    }

    static bool HasChar(string str, char ch)
    {
        for (int i = 0; i < str.Length; i++)
            if (str[i] == ch)
                return true;
        return false;
    }

    static bool HasSubstring(string str, string subStr)
    {
        if (subStr.Length > str.Length)
            return false;

        for (int i = 0; i <= str.Length - subStr.Length; i++)
        {
            bool strHasSubstring = true;

            for (int j = 0; j < subStr.Length; j++)
            {
                if (str[i + j] != subStr[j])
                {
                    strHasSubstring = false;
                    break;
                }
            }

            if (strHasSubstring)
                return true;
        }

        return false;
    }
}