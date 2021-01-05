#time "on"

open System
open System.IO

let area = 
    File.ReadAllLines(__SOURCE_DIRECTORY__ + "/../data/input03.txt")
    |> Array.map (fun line -> line |> Seq.map (fun x -> if x = '#' then 1 else 0) |> Seq.toArray)

let rec run (area : int array array) steps pos count =
    let x,y = pos
    if y + 1 = area.Length then
        count
    else
        let x = x + (fst steps)
        let y = y + (snd steps)
        let row = area.[y]
        let count = count + row.[x % row.Length]
        run area steps (x,y) count

// Part One

run area (3,1) (0,0) 0

// Part Two

[(1,1); (3,1); (5,1); (7,1); (1,2)]
|> List.map (fun steps -> run area steps (0,0) 0 |> int64)
|> List.reduce (*)
