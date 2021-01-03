#time "on"

module DayTwo =

    open System
    open System.IO
    open System.Text.RegularExpressions

    type Rule = {
        Char : char
        First : int
        Second : int
        Sample : string
    }

    let parseRule (line : string) =
        let groups = Regex.Match(line, @"^(\d+)-(\d+) (\w): (\w+)$").Groups
        {
            Char = groups.[3].Value.[0]
            First = Int32.Parse(groups.[1].Value)
            Second = Int32.Parse(groups.[2].Value)
            Sample = groups.[4].Value
        }

    let rules = 
        File.ReadAllLines "Data/input02.txt"
        |> Array.map parseRule

    // Part One

    let isValid1 (c:char) (text:string) first second = 
        let count = text |> Seq.filter (fun x -> x = c) |> Seq.length
        count >= first && count <= second

    rules
    |> Array.choose (fun rule -> 
        if isValid1 rule.Char rule.Sample rule.First rule.Second then Some rule else None)
    |> Array.length

    // Part Two

    let isValid2 (c:char) (text:string) first second = 
        text.Length >= second && 
        text.[first-1] = c && text.[second-1] <> c ||
        text.[first-1] <> c && text.[second-1] = c

    rules
    |> Array.choose (fun rule -> 
        if isValid2 rule.Char rule.Sample rule.First rule.Second then Some rule else None)
    |> Array.length
