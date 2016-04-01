type Item = { Price: decimal }

// price:decimal -> decimal
let withTax price = price * 1.14M;

let shirt = { Price = 10.00M }

do shirt.Price
|> withTax
|> printfn "%.2f"