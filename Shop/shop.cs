public class Shop {
    public string Name;
    public int Number;
    public string Owner;
    public int Value;

    public Shop(string Name,
     int Number,
     string Owner,
     int Value) {
        this.Name = Name;
        this.Number = Number;
        this.Owner = Owner;
        this.Value = Value;
    }
    public static string InputName(){
        Console.WriteLine("******************************************");
        Console.Write("Please input Name : ");
        return Console.ReadLine();
    }
    public static int InputNumber(){
        Console.Write("Please input Number : ");
        return int.Parse(Console.ReadLine());
    }
    public static string InputOwner(){
        Console.Write("Please input Owner Name : ");
        return Console.ReadLine();
    }
    public static int InputValue(){
        Console.Write("Please input Registered Value :");
        return int.Parse(Console.ReadLine());
    }
}