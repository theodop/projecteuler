module tests

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let AsDigits() =
    // Given a long with some value
    let num = 123456789L
    // get the digits as a sequence
    let digits = Digits.AsDigits(num)
    Assert.AreEqual(seq {1; 2; 3; 4; 5; 6; 7; 8; 9}, digits)
    ()

[<Test>]
let Palindrome_Match() =
    // given a number which is a palindrome
    let num = 906609L
    // check that it is a palindrome
    Assert.IsTrue(Digits.IsPalindrome(num))

[<Test>]
let Palindrome_NoMatch() = 
    // given a number which is not a palindrome
    let num = 12322L
    // check that it is a palindrome
    Assert.IsFalse(Digits.IsPalindrome(num))