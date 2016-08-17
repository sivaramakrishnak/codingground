using System.IO;
using System;

 class singleton
{
    public static singleton instance;
    private singleton()
    {
    }
    public static singleton getinstance()
    {
        if(instance==null)
        {
            instance = new singleton();
        }
       return instance;
    }
    
    public void print()
    {
        Console.WriteLine("Hello, World!");
    }
}

public class logger
{
    public static void Main(string[] args)
    {
        singleton obj= singleton.getinstance();
        obj.print();
        
    }
}
