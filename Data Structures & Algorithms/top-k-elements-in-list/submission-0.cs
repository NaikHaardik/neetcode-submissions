public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in freq)
        {
            int count = pair.Value;

            if (buckets[count] == null)
                buckets[count] = new List<int>();

            buckets[count].Add(pair.Key);
        }

        List<int> result = new List<int>();

        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                foreach (int num in buckets[i])
                {
                    result.Add(num);

                    if (result.Count == k)
                        break;
                }
            }
        }

        return result.ToArray();
    }
}