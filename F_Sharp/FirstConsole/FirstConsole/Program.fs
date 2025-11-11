// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"


module Say =
    let hello name =
        printfn "Hello %s" name


Say.hello("Luke")

let addnumbers a b = a + b 

let x = addnumbers 5 6

printfn "%i" x

let int2String (x: int) = string x

let y = int2String x

printfn "%s" y

