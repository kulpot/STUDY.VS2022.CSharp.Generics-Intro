using System;

//ref link:https://www.youtube.com/watch?v=q9h_AvUXIJ8&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er
//

//class PairIntInt
class Pair<T, U>
{
    //public int First { get; set; }
    public T First { get; set; }
    //public int Second { get; set; }
    public U Second { get; set; }
    public override string ToString()
    {
        return "{ " + First + ", " + Second + "}";
    }
}
/*
class PairIntFloat
{
    public int First { get; set; }
    public float Second { get; set; }
    public override string ToString()
    {
        return "{ " + First + ", " + Second + "}";
    }
}

class PairFloatFloat
{
    public float First { get; set; }
    public float Second { get; set; }
    public override string ToString()
    {
        return "{ " + First + ", " + Second + "}";
    }
}

class PairStringString
{
    public string First { get; set; }
    public string Second { get; set; }
    public override string ToString()
    {
        return "{ " + First + ", " + Second + "}";
    }
}*/

class MainClass
{
    /*static int Square(int value) { return value * value; }
    static void Main()
    {
        Console.WriteLine(Square(5));
        Console.WriteLine(Square(8));
        Console.WriteLine(Square(13));
    }*/
    static void Main()
    {
        //PairIntInt p = new PairIntInt { First = 5, Second = 20 };
        Pair<int, int> p = new Pair<int, int> { First = 5, Second = 20 };

        //PairStringString marriage1 = new PairStringString { First = "Suzy", Second = "Bob" };
        //PairStringString marriage2 = new PairStringString { First = "Fred", Second = "Bill" };
        //PairStringString marriage3 = new PairStringString { First = "Samantha", Second = "Rover" };
        Pair<string, string> marriage1 = new Pair<String, String> { First = "Suzy", Second = "Bob" };
        Pair<string, string> marriage2 = new Pair<String, String> { First = "Fred", Second = "Bill" };
        Pair<string, string> marriage3 = new Pair<String, String> { First = "Samantha", Second = "Rover" };
        Console.WriteLine(marriage1.ToString());

    }
}