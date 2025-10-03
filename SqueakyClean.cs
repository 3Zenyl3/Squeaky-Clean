public static class Identifier
{
    public static string Clean(string identifier)
    {
        string a = "";
        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                a += "CTRL";
            }
            else
            {
                a += c;
            }
        }

        a = a.Replace(" ", "_");

        string k = "";
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == '-' && i + 1 < a.Length)
            {
                k += char.ToUpper(a[i + 1]);
                i++;
            }
            else
            {
                k += a[i];
            }
        }

        string e = "";
        foreach (char c in k)
        {
            if ((char.IsLetter(c) && (c < 'α' || c > 'ω')) || c == '_')
            {
                e += c;
            }
        }

        return e;
    }
}
