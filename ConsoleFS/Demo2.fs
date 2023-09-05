module Demo2

let rec factorial n =
    match n with
    | 0 -> 1
    | _ -> n * factorial (n - 1)

let run () =
    let result = factorial 5
    printfn "Factorial: %d" result
