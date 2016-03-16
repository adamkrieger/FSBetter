#r "6.3_BillPayFs.dll"

IBillProcessor billProcessor = 
    new ReplacementBillPayProcessors.BetterBillProcessor();

billProcessor.PayBill(
    24,
    new Bill(){
        DatePaid = DateTime.Now,
        Amount = 13.28M,
        TypeOfPayment = PaymentType.Cash
    }
);