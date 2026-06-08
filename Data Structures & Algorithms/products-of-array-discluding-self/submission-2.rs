impl Solution {
    pub fn product_except_self(nums: Vec<i32>) -> Vec<i32> {
        let n = nums.len();
        let mut result: Vec<i32> = vec![1; n];

        result[0] = 1;
        for i in 1..n {
            result[i] = result[i - 1] * nums[i - 1];
        }

        let mut sufix = 1;
        for i in (0..n).rev() {
            result[i] *= sufix;
            sufix *= nums[i];
        }
        result
    }
}
