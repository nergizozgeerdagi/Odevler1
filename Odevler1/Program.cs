using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int sayi1;
        int sayi2 = 150;
        var result = SayiOut(out sayi1, sayi2);
        Console.WriteLine(result);
    }
    static int SayiOut(out int sayi1, int sayi2)
    {
        sayi1 = 100;
        return sayi1 + sayi2;

    }
}