public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
        {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            freq[num] = freq.GetValueOrDefault(num) + 1;
        }
        var buckets = new List<int>[nums.Length + 1];
        foreach (var (num, count) in freq)
        {
            buckets[count] = buckets[count] ?? new List<int>();
            buckets[count].Add(num);
        }

        var result = new List<int>();
        for (var i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }
        return result.Take(k).ToArray();
    }

}
