namespace csharp_leetcode
{
    public class Concatenation_of_array
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] output = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = nums[i];
                output[nums.Length + i] = nums[i];
            }
            return output;
        }
    }
}