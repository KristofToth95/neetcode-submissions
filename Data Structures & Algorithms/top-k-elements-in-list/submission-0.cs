public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        var buckets = new List<int>[nums.Length + 1];
        foreach (var n in nums) freq[n] = freq.GetValueOrDefault(n) + 1;

        foreach (var (n, f) in freq) (buckets[f] ??= new List<int>()).Add(n);

        var result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--) {
            if (buckets[i] != null)
                result.AddRange(buckets[i]);
        }

        return result.Take(k).ToArray();
    }
}
