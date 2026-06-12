impl Solution {
            pub fn is_valid_sudoku(board: Vec<Vec<char>>) -> bool {
        let mut rows: HashMap<usize, HashSet<char>> = HashMap::new();
        let mut col: HashMap<usize, HashSet<char>> = HashMap::new();
        let mut square: HashMap<usize, HashSet<char>> = HashMap::new();

        for (i, row) in board.iter().enumerate() {
            for (j, &cell) in row.iter().enumerate() {
                if cell == '.' {
                    continue;
                }
                let box_index = (i / 3) * 3 + (j / 3);

                let in_row = rows.entry(i).or_default().insert(cell);
                let in_col = col.entry(j).or_default().insert(cell);
                let in_square = square.entry(box_index).or_default().insert(cell);

                if !in_row || !in_col || !in_square {
                    return false;
                }
            }
        }
        true
    }

}
