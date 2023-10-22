namespace System;

class Programm
{
    static void Main(string[] args)
    {
        WorkWithUser workWithUser = new();
        workWithUser.WriteHi();
    }
}

class WorkWithUser
{
    public void WriteHi()
    {
        Console.WriteLine("Hi!");
    }
}