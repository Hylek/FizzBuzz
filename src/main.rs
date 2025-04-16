use std::collections::BTreeMap;

fn fizz_buzz(current_number: u32) -> String {
    let mut rules = BTreeMap::new();
    rules.insert(3, "Fizz");
    rules.insert(5, "Buzz");
    rules.insert(7, "Bazz");

    let result: String = rules.iter().filter_map(|(&divisor, &word)| {
        if current_number % divisor == 0 {
            Some(word)
        } else {
            None
        }
    }).collect();

    if result.is_empty() {
        current_number.to_string()
    } else {
        result
    }
}

fn main() {
    for i in 1..=100 {
        println!("{}", fizz_buzz(i));
    }
}
