using System;
public class Program {

 public static void Main(string[] args) {
     double Money = InputMoney();
     double M1000=Moneytrade.Cal1000(Money)
            ,M500=Moneytrade.Cal500(M1000)
            ,M100=Moneytrade.Cal100(M500)
            ,M50=Moneytrade.Cal50(M100)
            ,M20=Moneytrade.Cal20(M50)
            ,M10=Moneytrade.Cal10(M20)
            ,M5=Moneytrade.Cal5(M10)
            ,M2=Moneytrade.Cal2(M5)
            ,M1=Moneytrade.Cal1(M2)
            ,M_50=Moneytrade.Cal_50(M1)
            ,M_25=Moneytrade.Cal_25(M_50);


        int T1000=Moneytrade.trade1000(Money)
            ,T500=Moneytrade.trade500(M1000)
            ,T100=Moneytrade.trade100(M500)
            ,T50=Moneytrade.trade50(M100)
            ,T20=Moneytrade.trade20(M50)
            ,T10=Moneytrade.trade10(M20)
            ,T5=Moneytrade.trade5(M10)
            ,T2=Moneytrade.trade2(M5)
            ,T1=Moneytrade.trade1(M2)
            ,T_50=Moneytrade.trade_50(M1)
            ,T_25=Moneytrade.trade_25(M_50);
     
     PrintMoney(T1000,T500,T100,T50,T20,T10,T5,T2,T1,T_50,T_25);
 }

 public static double InputMoney(){
     Console.Write("Please input Money: ");
     return double.Parse(Console.ReadLine());
 }
 static void PrintMoney(int T1000,int T500,int T100,int T50,int T20,int T10,int T5,int T2,int T1,int T_50,int T_25){
    Console.WriteLine("1000 : {0}",T1000);
    Console.WriteLine("500 : {0}",T500);
    Console.WriteLine("100 : {0}",T100);
    Console.WriteLine("50 : {0}",T50);
    Console.WriteLine("20 : {0}",T20);
    Console.WriteLine("10 : {0}",T10);
    Console.WriteLine("5 : {0}",T5);
    Console.WriteLine("2 : {0}",T2);
    Console.WriteLine("1 : {0}",T1);
    Console.WriteLine("0.50 : {0}",T_50);
    Console.WriteLine("0.25 : {0}",T_25);
 }
}