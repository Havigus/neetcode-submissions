public class Solution
{
    public string Encode(IList<string> strs) =>
        string.Concat(strs.Select(s => $"{s.Length}#{s}"));

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            int j = s.IndexOf('#', i);
            int len = int.Parse(s[i..j]);
            result.Add(s[(j + 1)..(j + 1 + len)]);
            i = j + 1 + len;
        }
        return result;
    }
}



