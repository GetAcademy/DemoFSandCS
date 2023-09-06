module Demo3

let add1 x = x + 1
let double x = x * 2
let square x = x * x

let add1DoubleAndSquare = add1 >> double >> square

let run () =
    let resultWithPipe = 5 |> add1 |> double |> square
    let result = add1DoubleAndSquare 5
    printfn "Result: %d" result
