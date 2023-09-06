module Demo6

open System

let makeNameCaseWord (word:string) = 
    let head = word.[0] |> Char.ToUpper
    let tail = word.[1..].ToLower()
    string head + tail

let makeNameCase (name:string) =
    name.Split ' ' |> Array.map(makeNameCaseWord) |> String.concat " "  

let run () =
    let result = makeNameCase "tErjE AlbErt kOldErUp"
    printfn "%s" result
