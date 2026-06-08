impl Solution {
    pub fn encode(strs: Vec<String>) -> String {
        strs.iter().map(|s| format!("{}#{}", s.len(), s)).collect()
    }

    pub fn decode(s: String) -> Vec<String> {
        let mut result: Vec<String> = Vec::new();
        let mut i = 0;

        while i < s.len() {
            let j = s[i..].find('#').unwrap() + i;
            let len: usize = s[i..j].parse().unwrap();
            result.push(s[j + 1..j + 1 + len].to_string());
            i = j + 1 + len;
        }
        result
    }
}
