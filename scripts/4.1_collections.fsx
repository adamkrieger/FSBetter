let list = [ "Dinesh"; "Gilfoyle"; "Richard" ]

let array = [| "Rick"; "Morty"; "Summer" |]

let map =  
    [ "a", "Arya";
      "j", "Jon";
      "t", "Tyrion" ]
    |> Map.ofList

type ThingsThatYouCan =
    | Do
    | DoNot