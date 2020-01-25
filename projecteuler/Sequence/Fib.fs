module Fib
    let rec fibsRec a b max =
        if a + b < max then
            // The current element
            let current = a + b
            // Calculate all remaining elements recursively 
            // using 'b' as 'a' and 'current' as 'b' (in the next iteration)
            let rest = fibsRec b current  
            // Return the remaining elements with 'current' appended to the 
            // front of the resulting list (this constructs new list, 
            // so there is no mutation here!)
            current :: rest max
        else 
            [] // generated all elements - return empty list once we're done

    // generate list with 1, 2 and all other larger fibonaccis
    let fibs max = 1::2::(fibsRec 1 2 max)