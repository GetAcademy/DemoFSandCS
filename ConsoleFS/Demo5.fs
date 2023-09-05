module Demo5

let applyTwice f x = f (f x)
let doubleIt x = x * 2

let run () =
    let result = applyTwice doubleIt 3
    printfn "Result: %d" result
