public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        int n = names.Length;

        Dictionary<int, string> dict = new Dictionary<int, string>();

        for (int i = 0; i < n; i++)
        {
            dict.Add(heights[i], names[i]);
        }

        Array.Sort(heights);
        Array.Reverse(heights);

        for (int i = 0; i < n; i++)
        {
            names[i] = Convert.ToString(dict[heights[i]]);
        }

        return names;
    }
}