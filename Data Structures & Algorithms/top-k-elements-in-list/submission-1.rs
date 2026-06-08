impl Solution {
    pub fn top_k_frequent(nums: Vec<i32>, k: i32) -> Vec<i32> {
        let mut count: HashMap<i32, i32> = HashMap::new();
        for val in nums.iter() {
            count.entry(*val).and_modify(|x| *x += 1).or_insert(1);
        }
        let mut entries: Vec<(i32, i32)> = count.into_iter().collect();
        entries.sort_by(|a, b| b.1.cmp(&a.1));

        entries
            .iter()
            .take(k as usize)
            .map(|(val, _)| *val)
            .collect()
    }
}
