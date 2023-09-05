module Demo4

open System

type Shape =
    | Circle of float
    | Rectangle of float * float

let area shape =
    match shape with
    | Circle(radius) -> Math.PI * radius * radius
    | Rectangle(width, height) -> width * height

let run () =
    let circle = Circle(3.0)
    let rectangle = Rectangle(2.0, 4.0)
    
    let circleArea = area circle
    let rectArea = area rectangle

    printfn "Circle Area: %f" circleArea
    printfn "Rectangle Area: %f" rectArea
