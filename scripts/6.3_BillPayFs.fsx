module ReplacementBillPayProcessors
#r "6.1_BillPay.dll"

type BetterBillProcessor() =
    let calculateTax paymentMethod paymentAmount = 
        match paymentMethod with
        | PaymentType.Chickens -> paymentAmount * 1.17M
        | PaymentType.Mastercard
        | PaymentType.Visa
        | PaymentType.Cash -> paymentAmount * 1.05M

    interface IBillProcessor with
        member this.PayBill(id, bill) =
            let taxedAmount = calculateTax bill.TypeOfPayment bill.Amount
        
            printfn 
                "Paying bill in %d in F#, paid with %A, in the amount of $%.2f on %A." 
                id bill.TypeOfPayment taxedAmount bill.DatePaid