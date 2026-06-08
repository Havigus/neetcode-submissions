impl Solution {
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        let mut seen: HashMap<i32, usize> = HashMap::new();
        for (i, val) in nums.iter().enumerate() {
            let complement = target - val;
            if let Some(&j) = seen.get(&complement) {
                return vec![j as i32, i as i32];
            }
            seen.insert(*val, i);
        }
        vec![-1, -1]
    }
}
