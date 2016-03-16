#r "6.1_BillPay.dll"

public class BillProcessor : IBillProcessor
{
    public void PayBill(int id, Bill bill){
        Console.WriteLine(string.Format(
         "Paying bill {0}, paid with {1}, in the amount of ${2} on {3}.", 
         id, bill.TypeOfPayment, bill.Amount, bill.DatePaid));
    }
}

IBillProcessor billProcessor = new BillProcessor();

billProcessor.PayBill(
    24,
    new Bill(){ DatePaid = DateTime.Now,
                Amount = 13.28M,
                TypeOfPayment = PaymentType.Cash }
);