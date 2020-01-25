// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    while true do
        printfn "Enter question number |>"
        let input = Console.ReadLine()
        let number = input |> int

        let ans = 
            match number with
                | 1 -> Q1.run
                | 2 -> Q2.run
                | 3 -> Q3.run
                | 4 -> Q4.run
                | _ -> "Unknown question"

        Console.WriteLine(ans)
    
    0 // return an integer exit code
