module Demo6b

open System

let makeNameCaseWord (word:string) = 
    let firstLetter = Char.ToUpper word[0] 
    firstLetter.ToString() + word.Substring(1).ToLower()

let makeNameCase (name:string) =
    name.Split ' ' |> Array.map(makeNameCaseWord) |> String.concat " "  