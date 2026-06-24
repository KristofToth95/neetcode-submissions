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
        var i = 0;
        while (i < s.Length) {
            int hashIndex = s.IndexOf('#', i);
            int len = int.Parse(s.Substring(i, hashIndex - i));
            result.Add(s.Substring(hashIndex + 1, len));
            i = hashIndex + 1 + len;
        }

        return result;
    }
}
