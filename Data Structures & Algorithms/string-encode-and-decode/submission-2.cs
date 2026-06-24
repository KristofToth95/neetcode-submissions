public class Solution {
    public string Encode(IList<string> strs) {
        var result = "";

        foreach (var str in strs) {
            result += $"{str.Length}#{str}";
        }

        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        var i = 1;
        var lastEnd = 0;
        while (i < s.Length) {
            if (s[i] == '#' && Int32.TryParse(s.Substring(lastEnd, i - lastEnd), out var l)) {
                lastEnd = l + i + 1;
                result.Add(s.Substring(i + 1, l));
                i = i + l;
            }

            i++;
        }

        return result;
    }
}
