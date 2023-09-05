module Demo1

let add a b = a + b // Implisitt currying
let add5 = add 5 // Partial application

let run () =
    let result = add5 7 
    printfn "Result: %d" result