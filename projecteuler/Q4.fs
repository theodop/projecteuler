(*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*)

module Q4
    let run =
        let mutable largest = 0L
        for a in [999L.. -1L ..100L] do
            for b in [999L.. -1L .. a] do
                let thisNum = a * b
                largest <-
                    if largest < thisNum && Digits.IsPalindrome thisNum then
                        thisNum
                    else
                        largest

        largest |> string