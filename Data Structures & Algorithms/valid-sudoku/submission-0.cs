public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var col = new Dictionary<int, HashSet<char>>();
        var square = new Dictionary<int, HashSet<char>>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char cell = board[i][j];
                if (cell == '.')
                    continue;

                int boxIndex = (i / 3) * 3 + (j / 3);

                if (!rows.ContainsKey(i))
                    rows[i] = new HashSet<char>();
                if (!col.ContainsKey(j))
                    col[j] = new HashSet<char>();
                if (!square.ContainsKey(boxIndex))
                    square[boxIndex] = new HashSet<char>();

                if (!rows[i].Add(cell))
                    return false;
                if (!col[j].Add(cell))
                    return false;
                if (!square[boxIndex].Add(cell))
                    return false;
            }
        }
        return true;

    }
}
