module Tests

open System
open Xunit
open WindowsFormsApp2

[<Fact>]
let ``My test`` () =
    Assert.True(true)


[<Fact>]
public void testSimpleInterest()
{
    string si = WindowsFormsApp2.Maths.simpleInterest(1,2,3);
    Assert.Equal(6,si);
}


