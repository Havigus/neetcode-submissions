public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        // left pass: result[i] = product of everything to the left
        result[0] = 1;
        for (int i = 1; i < n; i++)
            result[i] = result[i - 1] * nums[i - 1];

        // right pass: multiply in product of everything to the right
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }
}
