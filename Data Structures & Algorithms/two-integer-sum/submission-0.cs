public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (hash.TryGetValue(target - nums[i], out var index))
                return [index, i];

            hash[nums[i]] = i;
        }

        return [];
    }
}
