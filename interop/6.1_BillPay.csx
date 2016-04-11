// csc /target:library 6.1_billpaydependencies.csx -> 6.1_billpaydependencies.dll
using System;

public enum PaymentType
{
    Cash, Visa, Mastercard, Chickens
}

public class Bill
{
    public DateTime DatePaid {get;set;}
    public decimal Amount {get;set;}
    public PaymentType TypeOfPayment {get;set;}    
}

public interface IBillProcessor
{
    void PayBill(int id, Bill bill);
}