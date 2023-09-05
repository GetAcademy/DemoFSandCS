module Demo3

let add1 x = x + 1
let double x = x * 2
let square x = x * x

let pipeline = add1 >> double >> square

let run () =
    let result = pipeline 5
    printfn "Result: %d" result
