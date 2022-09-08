using System;

public class Program {

 public static Shop InfoShop(string Name,
  int Number,
  string Owner,
  int Value) {
    return new Shop(Name,
    Number,
    Owner,
    Value);
 }
 public static void Main(string[] args) {
     string Name = Shop.InputName();
     int Number =Shop.InputNumber();
     string Owner = Shop.InputOwner();
     int Value =Shop.InputValue();
     
     Shop yourShop = InfoShop(Name, Number,Owner, Value);

     PrintShop(yourShop);
 }

 static void PrintShop(Shop yourShop) {
    Console.WriteLine("*************Shop Information*************");
    Console.WriteLine("Name : {0}", yourShop.Name);
    Console.WriteLine("Number : {0}", yourShop.Number);
    Console.WriteLine("Owner Name : {0}", yourShop.Owner);
    Console.WriteLine("Registered Value : {0}", yourShop.Value);
    Console.WriteLine("******************************************");
 }
}