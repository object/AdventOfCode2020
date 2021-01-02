#time "on"

module DayOne =

    open System
    open System.IO

    let rec findNwithSum sum n numbers accSum accNumbers =
        if sum < 0 || n < 0 then
            None
        else if sum = 0 && n = 0 then
            Some accNumbers
        else
            match numbers with
            | [] -> None
            | head :: tail ->
                match findNwithSum (sum-head) (n-1) tail (accSum+head) (head::accNumbers) with
                | Some result -> Some result
                | None -> findNwithSum sum n tail accSum accNumbers
    
    let numbers =
        File.ReadAllLines(__SOURCE_DIRECTORY__ + "/../data/input01.txt")
        |> Seq.toList
        |> List.map Int32.Parse 

    findNwithSum 2020 2 numbers 0 [] 
    |> Option.map (fun numbers -> numbers |> List.reduce (*))
    |> Option.defaultValue 0

    findNwithSum 2020 3 numbers 0 [] 
    |> Option.map (fun numbers -> numbers |> List.reduce (*))
    |> Option.defaultValue 0
