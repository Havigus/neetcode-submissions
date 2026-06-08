  public class Solution {
    public bool IsAnagram(string s, string t) {
      string sortedS = new string(s.OrderBy(c => c).ToArray());
      string sortedT = new string(t.OrderBy(c => c).ToArray());
      return sortedS.Equals(sortedT);
    }
}