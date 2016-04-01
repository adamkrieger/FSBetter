let stringArray = Some [| "elem" |] //Can't declare without assignment

// Will not compile, as stringArray is 'string[] option'
let item = stringArray.Length 
// Absence as a first class citizen
let firstElement = 
    stringArray |> function
             | Some arr when arr.Length > 0 -> Some arr.[0] 
             | _ -> None 