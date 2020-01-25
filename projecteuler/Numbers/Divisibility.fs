module Divisibility
    let factors (num:int64) =
        let upperBound = num |> float |> sqrt |> int64
        [1L..upperBound] |> Seq.filter (fun x -> num%x=0L)

    let isPrime (num:int64) =
        factors num |> Seq.length = 1