public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var results = new List<List<string>>();
        var list = strs.ToList();
        Span<int> count = stackalloc int[26];
        var j = 0;
        for (int i = 0; i < list.Count; i++) {
            results.Add([list[i]]);
            j = i + 1;
            while (j < list.Count) {
                if (list[i].Length != list[j].Length) {
                    j++;
                    continue;
                }

                for (int k = 0; k < list[i].Length; k++) {
                    count[list[i][k] - 'a']++;
                    count[list[j][k] - 'a']--;
                }

                var found = true;
                foreach (int d in count) {
                    if (d != 0) {
                        found = false;
                        break;
                    }
                }

                count.Clear();

                if (found) {
                    results[i].Add(list[j]);
                    list.RemoveAt(j);
                    continue;
                }

                j++;
            }
        }

        return results;
    }
}
