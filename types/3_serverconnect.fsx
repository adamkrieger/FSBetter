type Username = string
type Password = Password of string
type Server = | URL of string
              | IP of byte[]
type HttpResponse = Response of int * string
    
let sendSecureMessageToServer (username:Username) (password:Password) (destination:Server) message =
    printfn "Given %s - %A - %A" username password destination
    printfn "Message: %A" message
    Response (200, "Delivered Successfully")
     
let password = Password "12345"
let url = URL "https://localhost:9999/api/messages"

let sendMessage = sendSecureMessageToServer "adamk" password url 
do sendMessage "Oh hi, Mark."      |> ignore
do sendMessage "I have a problem." |> ignore

let sendNumber = sendSecureMessageToServer "bobbyD" password url
do sendNumber 9001                 |> ignore