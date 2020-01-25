module Digits

open System

    let AsDigits(num:int64) =
        // just very simple for now
        seq {
            let mutable numNow = num
            let mutable powerOfTen = 0.0
            while (Math.Pow(10.0, powerOfTen+1.0) < (num |> float)) do
                powerOfTen <- powerOfTen + 1.0

            while (Math.Pow(10.0, powerOfTen) > 1.0) do
                let thisBit = numNow / (Math.Pow(10.0, powerOfTen) |> int64)
                yield thisBit |> int 
                numNow <- numNow - thisBit * (Math.Pow(10.0, powerOfTen) |> int64)
                powerOfTen <- powerOfTen - 1.0

            yield numNow |> int
        }

    let IsPalindrome(num:int64) =
        let digits = AsDigits(num)
        let revDigits = digits |> Seq.rev
        (Seq.compareWith(fun x y -> x-y) digits revDigits) = 0