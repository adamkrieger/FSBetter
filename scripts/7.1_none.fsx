let stringArray = Some [| "elem" |]

let length = stringArray.[0]

let noneOfStringArray = 
    stringArray |> function
             | Some arr when arr.[0] = "test" -> Some arr 
             | _ -> None 


