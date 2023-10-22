namespace System;

class Programm
{
    static void Main(string[] args)
    {
        WorkWithUser workWithUser = new();
        workWithUser.Question();
        workWithUser.WriteBye();
        workWithUser.WriteHi();
    }
}

class WorkWithUser
{
    public void WriteHi()
    {
        Console.WriteLine("Hi!");
    }
    public void Question()
    {
        Console.WriteLine("Как вы?");
    }
    public void WriteBye()
    {
        Console.WriteLine("Bye!");
    }
    
}