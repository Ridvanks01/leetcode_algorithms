public class Solution
{
    public int LengthOfLastWord(string s)
    {

        string newS = s.Trim();

        string[] stringArray = newS.Split();

        string word = stringArray[stringArray.Length - 1];

        return word.Length;
    }
}